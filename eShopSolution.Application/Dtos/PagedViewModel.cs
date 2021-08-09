﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Dtos
{
    public class PagedViewModel<T>
    {
        public List<T> Items { get; set; }
        public int Total { get; set; }
    }
}
