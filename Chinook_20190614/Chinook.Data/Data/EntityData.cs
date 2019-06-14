using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Chinook.Data
{
    // T의 제약 조건을 걸어 준다...
    public class EntityData<T> where T:class
    {
        public List<T> GetAll()
        {
            using(ChinookEntities context = DbContextFactory.Create())
            {
                // DbSet의 제약조건과 일치해야 한다.
                return context.Set<T>().ToList();
            }
        }

        public int GetCount()
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                return context.Set<T>().Count();
            }
        }

        public void Insert(T entity)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        
    }
}
