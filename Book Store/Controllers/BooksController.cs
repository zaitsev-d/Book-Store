using BookStore.ViewModels;
using Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks allBooks;
        private readonly IBooksCategory allCategories;

        public BooksController(IAllBooks _allBooks, IBooksCategory booksCategory)
        {
            allBooks = _allBooks;
            allCategories = booksCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Books Page";
            BooksListViewModel obj = new BooksListViewModel();
            obj.GetBooks = allBooks.Books;
            obj.CurrentCategory = "Books";
            return View(obj);
        }
    }
}
