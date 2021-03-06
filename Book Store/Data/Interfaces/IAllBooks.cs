﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> GetBooks { get; }
        Book GetObjectBook(int bookID);
    }
}
