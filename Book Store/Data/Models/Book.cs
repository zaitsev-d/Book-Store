using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool isFavourite { get; set; }
        public bool Available { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
