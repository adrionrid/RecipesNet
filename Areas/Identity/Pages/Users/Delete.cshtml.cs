using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RecipesNet.Areas.Identity.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public DeleteModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public IdentityUser IdentityUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IdentityUser = await _userManager.FindByIdAsync(id);

            if (IdentityUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IdentityUser = await _userManager.FindByIdAsync(id);

            if (IdentityUser != null)
            {
                await _userManager.DeleteAsync(IdentityUser);
            }

            return RedirectToPage("./Index");
        }
    }
}