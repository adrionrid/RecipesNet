using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Cuisines
{
    public class DeleteModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public DeleteModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cuisine Cuisine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cuisine = await _context.Cuisine.FirstOrDefaultAsync(m => m.Id == id);

            if (Cuisine == null)
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

            Cuisine = await _context.Cuisine.FindAsync(id);

            if (Cuisine != null)
            {
                _context.Cuisine.Remove(Cuisine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
