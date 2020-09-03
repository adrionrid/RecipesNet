using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Recipes
{
    public class DetailsModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public DetailsModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }
        public EnergyValue EnergyValue { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipe
                .Include(r => r.DishType)
                .Include(r => r.Ingredients)
                    .ThenInclude(r => r.Ingredient)
                        .ThenInclude(r => r.EnergyValue)
                .Include(r => r.Cuisine)
                .Include(r => r.Instructions).FirstOrDefaultAsync(m => m.Id == id);

            EnergyValue = Recipe.Ingredients.EnergyValue();

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
