using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Models
{
    public class InstructionStep
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Step")]
        public string Entry { get; set; }

        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
    }
}
