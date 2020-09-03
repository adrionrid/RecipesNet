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
using Newtonsoft.Json;
using RecipesNet.Code;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.Recipes
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
        public Recipe Recipe { get; set; }
        [BindProperty]
        public List<IngredientItem> Ingredients { get; set; }
        [BindProperty]
        public List<InstructionStep> Instructions { get; set; }

        public SelectList IngredientSelect { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

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
                .Include(r => r.Cuisine)
                .Include(r => r.Instructions).FirstOrDefaultAsync(m => m.Id == id);

            if (Recipe == null)
            {
                return NotFound();
            }

            SetCurrentRecipe();

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                SetCurrentRecipe();
                return Page();
            }

            foreach (var item in Recipe.Ingredients)
                _context.Attach(item).State = EntityState.Modified;

            var i = _context.IngredientItem.AsEnumerable();
            var del = i.Where(c => c.RecipeId == Recipe.Id).Where(p1 => !Recipe.Ingredients.Any(p2 => p2.Id == p1.Id));
            foreach (var item in del)
                _context.Attach(item).State = EntityState.Deleted;

            foreach (var item in Ingredients)
            {
                item.RecipeId = Recipe.Id;
            }

            _context.IngredientItem.AddRange(Ingredients);


            foreach (var item in Recipe.Instructions)
                _context.Attach(item).State = EntityState.Modified;

            var it = _context.InstructionStep.AsEnumerable();
            var delIt = it.Where(c => c.RecipeId == Recipe.Id).Where(p1 => !Recipe.Instructions.Any(p2 => p2.Id == p1.Id));

            foreach (var item in delIt)
                _context.Attach(item).State = EntityState.Deleted;

            foreach (var item in Instructions)
            {
                item.RecipeId = Recipe.Id;
            }

            _context.InstructionStep.AddRange(Instructions);

            _context.Attach(Recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

                await ImageUploader.Upload(_environment, Image, nameof(Recipes), Recipe.Id.ToString());
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(Recipe.Id))
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

        private bool RecipeExists(int id)
        {
            return _context.Recipe.Any(e => e.Id == id);
        }

        public IActionResult OnGetIngredients()
        {
            var list = new SelectList(_context.Ingredient, nameof(Ingredient.Id), nameof(Ingredient.Name));
            var json = JsonConvert.SerializeObject(list);
            return new JsonResult(json);
        }

        void SetCurrentRecipe()
        {
            IngredientSelect = new SelectList(_context.Ingredient.AsNoTracking(), nameof(Ingredient.Id), nameof(Ingredient.Name));
            ViewData[nameof(Recipe.CuisineId)] = new SelectList(_context.Cuisine, nameof(Cuisine.Id), nameof(Cuisine.Name));
            ViewData[nameof(Recipe.DishTypeId)] = new SelectList(_context.DishType, nameof(DishType.Id), nameof(DishType.Name));
        }
    }
}
