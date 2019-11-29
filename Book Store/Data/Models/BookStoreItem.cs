using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BookStoreItem
    {
        public int ID { get; set; }
        public Book BookItem { get; set; }
        public decimal Price { get; set; }

        public string BookStoreID { get; set; }
    }
}
