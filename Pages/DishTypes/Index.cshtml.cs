﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.DishTypes
{
    public class IndexModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public IndexModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<DishType> DishType { get;set; }

        public async Task OnGetAsync()
        {
            DishType = await _context.DishType.ToListAsync();
        }
    }
}
