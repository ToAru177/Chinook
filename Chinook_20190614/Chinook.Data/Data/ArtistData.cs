using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Chinook.Data
{
    public class ArtistData : EntityData<Artist>
    {
        public Artist GetByArtistId(int artistId)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                // 조건을 만족하는 첫번째 원소를 반환한다.
                // OrDefault는 아무것도 없으면 기본값(null)을 반환한다.
                return context.Artists.FirstOrDefault(x=>x.ArtistId == artistId);
            }
        } 

        public List<Artist> Search(string name)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Artists
                            where x.Name.Contains(name)
                            select x;

                List<Artist> list = query.ToList();
                context.Dispose();

                return list;
            }
        }
    }
}
