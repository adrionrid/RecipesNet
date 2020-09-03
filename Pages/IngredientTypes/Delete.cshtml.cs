using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.IngredientTypes
{
    public class DeleteModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public DeleteModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IngredientType IngredientType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IngredientType = await _context.IngredientType.FirstOrDefaultAsync(m => m.Id == id);

            if (IngredientType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IngredientType = await _context.IngredientType.FindAsync(id);

            if (IngredientType != null)
            {
                _context.IngredientType.Remove(IngredientType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
