using BookStore.ViewModels;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IAllBooks _bookRepository;

        public HomeController(IAllBooks bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public ViewResult Index()
        {
            var homeBooks = new HomeViewModel
            {
                favBooks = _bookRepository.GetBooks
            };
            return View(homeBooks);
        }
    }
}
