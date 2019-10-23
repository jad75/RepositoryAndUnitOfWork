using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Compostion Root
            using (ShopDbContext shopDbContext = new ShopDbContext())
            {
                var unitiOfWork = new ShopUnitOfWorkDbContextAdapter(shopDbContext,
                    new ArticleEntityRepositoryAdapter(shopDbContext.Articles),
                    new EntityRepositoryAdapter<Invoice>(shopDbContext.Invoices));
                var soap = new Article { Name = "Soap", Price = 3.99m };
                var fakeMustache = new Article { Name = "Fake Mustache", Price = 7.00m };
                unitiOfWork.Articles.Add(soap);
                unitiOfWork.Articles.Add(fakeMustache);
                var invoice = new Invoice
                {
                    CustomerName = "Joe Safiov",
                    Items = new List<InvoiceItem>
                                            {
                                                new InvoiceItem{Article=soap,Quantity = 2},
                                                new InvoiceItem{Article= fakeMustache, Quantity= 1}
                                            }
                };
                unitiOfWork.Invoices.Add(invoice);
                unitiOfWork.SaveChanges();
            }
        }
    }
}
