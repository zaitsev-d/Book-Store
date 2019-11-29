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
    public class BooksController : Controller
    {
        private readonly IAllBooks allBooks;
        private readonly IBooksCategory allCategories;

        public BooksController(IAllBooks _allBooks, IBooksCategory booksCategory)
        {
            allBooks = _allBooks;
            allCategories = booksCategory;
        }

        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = null;
            string currCategory = default;

            ViewBag.Title = "Books Page";

            if (string.IsNullOrEmpty(category))
            {
                books = allBooks.Books.OrderBy(i => i.ID);
            }
            else
            {
                if (string.Equals("Fantasy", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = allBooks.Books.Where(i => i.Category.Name.Equals("Fantasy"));
                }
                else if (string.Equals("Horrors", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = allBooks.Books.Where(i => i.Category.Name.Equals("Horrors"));
                }
                else if (string.Equals("Fantastic", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = allBooks.Books.Where(i => i.Category.Name.Equals("Fantastic"));
                }
                else if (string.Equals("Technical literature", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = allBooks.Books.Where(i => i.Category.Name.Equals("Technical literature"));
                }
                else if (string.Equals("Biography", category, StringComparison.OrdinalIgnoreCase))
                {
                    books = allBooks.Books.Where(i => i.Category.Name.Equals("Biography"));
                }
                currCategory = _category;
            }

            var bookObj = new BooksListViewModel
            {
                GetBooks = books,
                CurrentCategory = _category
            };

            return View(bookObj);
        }
    }
}
