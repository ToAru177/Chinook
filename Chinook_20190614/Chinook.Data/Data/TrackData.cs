using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class TrackData : EntityData<Track>
    {
        public Track GetByTrackId(int trackId)
        {
            using(ChinookEntities context = DbContextFactory.Create())
            {
                return context.Tracks.FirstOrDefault(x => x.TrackId == trackId);
            }
        }

        // int? => NULLable<int>
        public List<Track> Search(string name, int? albumId, int? genreId)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {

                var query = from x in context.Tracks
                                          select new
                                          {
                                              Track = x,
                                              AlbumTitle = x.Album.Title,
                                              GenreName = x.Genre.Name
                                          };

                //IQueryable<Track> query = from x in context.Tracks
                //                          select x;


                //if(name != null && name != "")
                if (string.IsNullOrEmpty(name) == false)
                    query = query.Where(x => x.Track.Name.Contains(name));

                if (albumId.HasValue)
                    query = query.Where(x => x.Track.AlbumId == albumId);

                if (genreId.HasValue)
                    query = query.Where(x => x.Track.GenreId == genreId);

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Track.AlbumTitle = item.AlbumTitle;
                    item.Track.GenreName = item.GenreName;
                }

                //List<Track> tracks = query.ToList();
                return list.ConvertAll(x => x.Track);
            }
        }
    }
}
