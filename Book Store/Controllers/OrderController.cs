using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly Cart storeCart;

        public OrderController(IAllOrders allOrders, Cart storeCart)
        {
            this.allOrders = allOrders;
            this.storeCart = storeCart;
        }
        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            storeCart.ListStoreItems = storeCart.GetStoreItems();
            if (storeCart.ListStoreItems.Count == 0) 
                ModelState.AddModelError("","Cart don't never null.");
            if(ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order processed successfully.";
            return View();
        }
    }
}
