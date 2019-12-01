using BookStore.Data;
using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly Cart storeCart;

        public OrdersRepository(AppDBContent appDBContent, Cart storeCart)
        {
            this.appDBContent = appDBContent;
            this.storeCart = storeCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = storeCart.ListStoreItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    BookID = el.BookItem.ID,
                    OrderID = order.ID,
                    Price = el.BookItem.Price
                };

                appDBContent.OrderDetails.Add(orderDetail);
            }

            appDBContent.SaveChanges();
        }
    }
}
