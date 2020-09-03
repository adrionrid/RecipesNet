using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Data
{
    public static class SeedDataRoles
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                if (context.Roles.Any())
                    return;

                string Administrator = nameof(Administrator);
                string Moderator = nameof(Moderator);
                string User = nameof(User);
                string AdministratorId = Guid.NewGuid().ToString();
                string AdministratorName = "admin@initial";

                var hasher = new PasswordHasher<IdentityUser>();

                context.Roles.AddRange(
                    new IdentityRole { Id = AdministratorId, Name = Administrator, NormalizedName = Administrator.ToUpper() },
                    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = Moderator, NormalizedName = Moderator.ToUpper() },
                    new IdentityRole { Id = Guid.NewGuid().ToString(), Name = User, NormalizedName = User.ToUpper() }
                );

                var u = new IdentityUser
                {
                    Id = AdministratorId,
                    UserName = AdministratorName,
                    NormalizedUserName = AdministratorName.ToUpper(),
                    Email = AdministratorName,
                    NormalizedEmail = AdministratorName.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                u.PasswordHash = hasher.HashPassword(u, "secret");

                context.Users.AddRange(
                    u
                );

                context.UserRoles.AddRange(
                    new IdentityUserRole<string>
                    {
                        RoleId = AdministratorId,
                        UserId = AdministratorId
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
