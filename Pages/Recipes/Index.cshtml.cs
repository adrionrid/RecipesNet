using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public IndexModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public PaginatedList<Recipe> Recipe { get;set; }


        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync(int? pageIndex)
        {
            var Recipes = _context.Recipe
                .Include(r => r.DishType)
                .Include(r => r.Ingredients)
                .Include(r => r.Cuisine)
                .Include(r => r.Instructions)
                .AsQueryable();

            if (!string.IsNullOrEmpty(SearchString))
            {
                Recipes = Recipes.Where(s => s.Name.Contains(SearchString));
            }

            var pageSize = 10;
            Recipe = await PaginatedList<Recipe>.CreateAsync(
                Recipes, pageIndex ?? 1, pageSize);
        }
    }
}
