using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;

namespace RecipesNet.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Dish type")]
        public int DishTypeId { get; set; }
        public DishType DishType { get; set; }

        [Required]
        [DisplayName("Cuisine")]
        public int CuisineId { get; set; }
        public Cuisine Cuisine { get; set; }

        [Required]
        [DisplayName("Cooking time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CookingTime { get; set; }

        [Required]
        public IList<IngredientItem> Ingredients { get; set; }
        [Required]
        public IList<InstructionStep> Instructions { get; set; }

        public Recipe()
        {
            CookingTime = DateTime.MinValue;
        }
    }
}
