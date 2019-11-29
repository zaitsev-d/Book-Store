﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
