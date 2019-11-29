using BookStore.ViewModels;
using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class CartController : Controller
    {
        private IAllBooks _bookRepository;
        private readonly Cart _cart;

        public CartController(IAllBooks bookRepository, Cart cart)
        {
            _bookRepository = bookRepository;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.GetStoreItems();
            _cart.ListStoreItems = items;

            var obj = new BookStoreCartModel
            {
                cart = _cart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int ID)
        {
            var item = _bookRepository.Books.FirstOrDefault(i => i.ID == ID);
            if(item != null)
            {
                _cart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
