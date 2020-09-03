using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Models;
using RecipesNet.Pages;

namespace RecipesNet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RecipesNet.Models.Recipe> Recipe { get; set; }
        public DbSet<RecipesNet.Models.Cuisine> Cuisine { get; set; }
        public DbSet<RecipesNet.Models.DishType> DishType { get; set; }
        public DbSet<RecipesNet.Models.InstructionStep> InstructionStep { get; set; }
        public DbSet<RecipesNet.Models.IngredientType> IngredientType { get; set; }
        public DbSet<RecipesNet.Models.Ingredient> Ingredient { get; set; }
        public DbSet<RecipesNet.Models.IngredientItem> IngredientItem { get; set; }
        public DbSet<RecipesNet.Models.EnergyValue> EnergyValue { get; set; }

        public DbSet<RecipesNet.Models.Entry> Entries { get; set; }
        public DbSet<RecipesNet.Models.RecipeEntry> RecipeEntry { get; set; }
        public DbSet<RecipesNet.Models.Rating> Rating { get; set; }
    }
}
