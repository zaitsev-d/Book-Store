using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> GetBooks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
