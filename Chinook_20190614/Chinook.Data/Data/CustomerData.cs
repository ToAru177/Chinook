using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Chinook.Data
{
    public class CustomerData : EntityData<Customer>
    {
        //private static CustomerData _instance;

        //public static CustomerData Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new CustomerData();

        //        return _instance;
        //    }

        //}


        public List<string> GetCountry()
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Customers
                            select x.Country;

                return query.ToList();
            }
        }

        public List<Customer> Search(string email)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                var query = from x in context.Customers
                            where x.Email.Contains(email)
                            select x;

                List<Customer> list = query.ToList();
                context.Dispose();

                return list;
            }
        }
    }
}
