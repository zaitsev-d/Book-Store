using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category { Name = "Fantasy", Description = "Bla Bla"},
                    new Category { Name = "Horrors", Description = "Bla Bla"}
                };
            }
        }
    }
}
