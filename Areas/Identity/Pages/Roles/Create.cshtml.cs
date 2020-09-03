using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipesNet.Areas.Identity.Pages.Roles
{
    public class CreateModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public CreateModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IdentityRole IdentityRole { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _roleManager.CreateAsync(IdentityRole);

            return RedirectToPage("./Index");
        }
    }
}