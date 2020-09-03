using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipesNet.Models
{
    public class IngredientType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
