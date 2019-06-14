using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Chinook.Data
{
    public class AlbumData : EntityData<Album>
    {

        public string GetTitle(int albumId)
        {
            using(ChinookEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Albums
                            where x.AlbumId == albumId
                            select x.Title;

                return query.FirstOrDefault();
            }
        }

        /*
        public List<Album> Search(string title, int artistId)
        {
            ChinookEntities context = new ChinookEntities();

            var query = from x in context.Albums
                        where x.Title.Contains(title) &&
                        x.ArtistId == artistId
                        select x;

            var albums = query.ToList();

            // Round Trip... 2번 발생
            // 위의 albums의 query와 Dictionary의 query 발생
            Dictionary<int, string> artistNames = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);

            foreach (Album album in albums)
            {
                album.ArtistName = artistNames[album.ArtistId]; // logN
            }

            //List<Artist> artists = context.Artists.ToList();

            //foreach (Album album in albums)
            //{
            //    // Find() 함수는 순차 정렬하여 처리하기 때문에 데이터가 많을 경우 비효율적이다...
            //    Artist artist = artists.Find(x => x.ArtistId == album.ArtistId);
            //    album.ArtistName = artist.Name;
            //}

            context.Dispose();

            return albums;
        }
        */

        public List<Album> Search(string title, int artistId)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                context.Database.Log = x => Debug.WriteLine(x);

                var query2 = from x in context.Tracks
                             select new { x.TrackId, x.Name };

                var list2 = query2.ToList();

                Dictionary<int, string> trackNames = context.Tracks.ToDictionary(x => x.TrackId, x => x.Name);

                var query = from x in context.Albums
                            where x.Title.Contains(title) &&
                            x.ArtistId == artistId
                            select x;

                var albums = query.ToList();

                Dictionary<int, string> artistNames = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);

                foreach (Album album in albums)
                {
                    album.ArtistName = artistNames[album.ArtistId]; // logN
                }

                context.Dispose();

                return albums;
            }
        }

        /// <summary>
        /// 익명 타입 사용..
        /// </summary>
        /// <param name="title"></param>
        /// <param name="artistId"></param>
        /// <returns></returns>
        public List<Album> Search2(string title, int artistId)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {

                var query = from x in context.Albums
                            where x.Title.Contains(title) &&
                            x.ArtistId == artistId
                            select new
                            {
                                Album = x,
                                ArtistName = x.Artist.Name
                            };


                var list = query.ToList();


                foreach (var item in list)
                {
                    item.Album.ArtistName = item.ArtistName; // logN
                }

                context.Dispose();

                // List에 담긴 데이터 전체 형식 변환하여 리턴하기
                return list.ConvertAll(x=>x.Album);
            }
        }
    }
}
