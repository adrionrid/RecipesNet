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

namespace RecipesNet.Pages.IngredientTypes
{
    public class EditModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public EditModel(RecipesNet.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(IngredientType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientTypeExists(IngredientType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool IngredientTypeExists(int id)
        {
            return _context.IngredientType.Any(e => e.Id == id);
        }
    }
}
