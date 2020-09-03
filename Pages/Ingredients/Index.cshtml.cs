using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Ingredients
{
    public class IndexModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public IndexModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PaginatedList<Ingredient> Ingredient { get; set; }

        public async Task OnGetAsync(int? pageIndex)
        {
            var Ingredients = _context.Ingredient
                .Include(s => s.Type)
                .Include(s => s.EnergyValue);

            var pageSize = 10;
            Ingredient = await PaginatedList<Ingredient>.CreateAsync(
                Ingredients, pageIndex ?? 1, pageSize);

            //Ingredient = await _context.Ingredient.ToListAsync();
        }
    }
}
