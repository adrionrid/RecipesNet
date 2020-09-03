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

namespace RecipesNet.Pages.Cuisines
{
    public class EditModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public EditModel(RecipesNet.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cuisine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuisineExists(Cuisine.Id))
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

        private bool CuisineExists(int id)
        {
            return _context.Cuisine.Any(e => e.Id == id);
        }
    }
}
