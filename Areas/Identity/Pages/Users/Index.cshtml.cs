using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RecipesNet.Areas.Identity.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IList<IdentityUser> Users { get; set; }
        public IList<IdentityRole> Roles { get; set; }

        public async Task OnGetAsync()
        {
            Users = await _userManager.Users.ToListAsync();
            Roles = await _roleManager.Roles.ToListAsync();
        }

        public async Task<IList<string>> GetIdentityRole(IdentityUser user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<IList<string>> AddIdentityRole(IdentityUser user)
        {
            var allRoles = _roleManager.Roles.ToList();
            return await _userManager.GetRolesAsync(user);
        }
    }
}