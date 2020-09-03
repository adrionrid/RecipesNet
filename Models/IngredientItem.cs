using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Models
{
    public class IngredientItem
    {
        public int Id { get; set; }

        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Quantity { get; set; }

        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
    }

    public static class IngredientItemExtention
    {
        public static EnergyValue EnergyValue(this IngredientItem ingredient)
        {
            return new EnergyValue
            {
                Protein = ingredient.Ingredient.EnergyValue.Protein * (int)((float)ingredient.Quantity / 100),
                Fat = ingredient.Ingredient.EnergyValue.Fat * (int)((float)ingredient.Quantity / 100),
                Carbohydrate = ingredient.Ingredient.EnergyValue.Carbohydrate * (int)((float)ingredient.Quantity / 100),
                Calorie = ingredient.Ingredient.EnergyValue.Calorie * (int)((float)ingredient.Quantity / 100)
            };
        }

        public static EnergyValue EnergyValue(this ICollection<IngredientItem> ingredients)
        {
            return new EnergyValue
            {
                Protein = ingredients.Sum(x => x.EnergyValue().Protein),
                Fat = ingredients.Sum(x => x.EnergyValue().Fat),
                Carbohydrate = ingredients.Sum(x => x.EnergyValue().Carbohydrate),
                Calorie = ingredients.Sum(x => x.EnergyValue().Calorie)
            };
        }
    }
}
