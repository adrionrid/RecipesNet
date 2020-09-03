using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecipesNet.Data;
using RecipesNet.Models;

namespace RecipesNet.Pages.DishTypes
{
    public class CreateModel : PageModel
    {
        private readonly RecipesNet.Data.ApplicationDbContext _context;

        public CreateModel(RecipesNet.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DishType DishType { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DishType.Add(DishType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
