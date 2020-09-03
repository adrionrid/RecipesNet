using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesNet.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name", Prompt = "Name")]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Description", Prompt = "Description")]
        public string Description { get; set; }

        [Display(Name = "Type", Prompt = "Type")]
        public IngredientType Type { get; set; }
        public int TypeId { get; set; }

        public EnergyValue EnergyValue { get; set; }
        public int EnergyValueId { get; set; }
    }
}
