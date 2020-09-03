using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RecipesNet.Code;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Recipes
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

        public IActionResult OnGet(Recipe recipe)
        {
            SetCurrentRecipe();

            return Page();
        }

        [BindProperty]
        public Recipe Recipe { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                SetCurrentRecipe();
                return Page();
            }

            _context.Recipe.Add(Recipe);

            await _context.SaveChangesAsync();

            await ImageUploader.Upload(_environment, Image, nameof(Recipes), Recipe.Id.ToString());

            return RedirectToPage("./Index");
        }

        public IActionResult OnGetIngredients()
        {
            var list = new SelectList(_context.Ingredient, nameof(Ingredient.Id), nameof(Ingredient.Name));
            var json = JsonConvert.SerializeObject(list);
            return new JsonResult(json);
        }

        void SetCurrentRecipe()
        {
            ViewData[nameof(Recipe.DishTypeId)] = new SelectList(_context.Set<DishType>(), nameof(Recipe.DishType.Id), nameof(Recipe.DishType.Name));
            ViewData[nameof(Recipe.CuisineId)] = new SelectList(_context.Set<Cuisine>(), nameof(Recipe.Cuisine.Id), nameof(Recipe.Cuisine.Name));
            ViewData[nameof(Recipe.Ingredients)] = new SelectList(_context.Ingredient, nameof(Ingredient.Id), nameof(Ingredient.Name));
        }
    }
}
