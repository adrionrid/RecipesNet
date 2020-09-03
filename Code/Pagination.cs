using Microsoft.EntityFrameworkCore;
using RecipesNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet
{
    public class Pagination
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public Pagination(int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public bool ShowPrevious => PageIndex > 1;
        public bool ShowNext => PageIndex < TotalPages;
        public bool ShowFirst => PageIndex != 1;
        public bool ShowLast => PageIndex != TotalPages && HasNextPage;
    }
}
