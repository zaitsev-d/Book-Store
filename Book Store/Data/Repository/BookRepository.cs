using BookStore.Data;
using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BookRepository : IAllBooks
    {
        private readonly AppDBContent appDBContent;

        public BookRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Book> Books => appDBContent.Book.Include(c => c.Category);

        public IEnumerable<Book> GetBooks => appDBContent.Book.Where(p => p.isFavourite).Include(c => c.Category);

        public Book GetObjectBook(int bookID) => appDBContent.Book.FirstOrDefault(p => p.ID == bookID);
    }
}
