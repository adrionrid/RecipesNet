using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Code;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Ingredients
{
    public class CreateModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public CreateModel(RecipesNet.Data.ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            IngredientTypes = new SelectList(_context.IngredientType.AsNoTracking(), nameof(IngredientType.Id), nameof(IngredientType.Name));
            return Page();
        }

        [BindProperty]
        public Ingredient Ingredient { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public SelectList IngredientTypes { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                IngredientTypes = new SelectList(_context.IngredientType.AsNoTracking(), nameof(IngredientType.Id), nameof(IngredientType.Name), Ingredient.TypeId);
                return Page();
            }


            _context.Ingredient.Add(Ingredient);

            await _context.SaveChangesAsync();

            await ImageUploader.Upload(_environment, Image, nameof(Ingredients), Ingredient.Id.ToString());

            return RedirectToPage("./Index");
        }
    }
}
