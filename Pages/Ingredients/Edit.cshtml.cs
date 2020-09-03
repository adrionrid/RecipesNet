using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Code;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Ingredients
{
    public class EditModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public EditModel(RecipesNet.Data.ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public Ingredient Ingredient { get; set; }

        public SelectList IngredientTypes { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient
                .Include(s => s.Type)
                .Include(s => s.EnergyValue)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Ingredient == null)
            {
                return NotFound();
            }

            IngredientTypes = new SelectList(_context.Set<IngredientType>(), nameof(Ingredient.Type.Id), nameof(Ingredient.Name));

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                IngredientTypes = new SelectList(_context.Set<IngredientType>(), nameof(Ingredient.Type.Id), nameof(Ingredient.Name));
                return Page();
            }

            _context.Attach(Ingredient).State = EntityState.Modified;
            _context.Attach(Ingredient.EnergyValue).State = EntityState.Modified;


            try
            {
                await _context.SaveChangesAsync();

                await ImageUploader.Upload(_environment, Image, nameof(Ingredients), Ingredient.Id.ToString());
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientExists(Ingredient.Id))
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

        private bool IngredientExists(int id)
        {
            return _context.Ingredient.Any(e => e.Id == id);
        }
    }
}
