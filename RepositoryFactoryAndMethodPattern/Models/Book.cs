﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public class Book : EntityBase
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

    }
}
