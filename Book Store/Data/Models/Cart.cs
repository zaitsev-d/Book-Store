using BookStore.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Cart
    {
        private readonly AppDBContent appDBContent;

        public Cart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string StoreCartID { get; set; }

        public List<BookStoreItem> ListStoreItems { get; set; }

        public static Cart GetItem(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string bookStoreID = session.GetString("BookID") ?? Guid.NewGuid().ToString();

            session.SetString("BookID", bookStoreID);

            return new Cart(context) { StoreCartID = bookStoreID };
        }

        public void AddToCart(Book book)
        {
            appDBContent.BookStoreItems.Add(new BookStoreItem {
                BookStoreID = StoreCartID,
                BookItem = book,
                Price = book.Price
            });

            appDBContent.SaveChanges();
        }

        public List<BookStoreItem> GetStoreItems()
        {
            return appDBContent.BookStoreItems.Where(c => c.BookStoreID == StoreCartID).Include(s => s.BookItem).ToList();
        }
    }
}
