using System;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.Data
{
    public class InvoiceData : EntityData<Invoice>
    {
        private static InvoiceData _instance;

        public static InvoiceData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InvoiceData();

                return _instance;
            }

        }

        public List<Invoice> Search(string email, string country, DateTime date1, DateTime date2)
        {
            using (ChinookEntities context = DbContextFactory.Create())
            {
                //context.Database.Log = x => Debug.WriteLine(x);

                var query = from x in context.Invoices
                            where x.BillingCountry.Contains(country) &&
                            x.Customer.Email.Contains(email) &&
                            x.InvoiceDate >= date1 && x.InvoiceDate < date2
                            select new
                            {
                                Invoice = x,
                                CustomerEmail = x.Customer.Email
                            };                

                var list = query.ToList();


                foreach (var item in list)
                {
                    item.Invoice.CustomerEmail = item.CustomerEmail; // logN
                }

                context.Dispose();

                // List에 담긴 데이터 전체 형식 변환하여 리턴하기
                return list.ConvertAll(x => x.Invoice);
            }
        }
    }

}
