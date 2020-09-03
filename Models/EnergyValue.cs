using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Models
{
    [Display(Name = "Energy value")]
    public class EnergyValue
    {
        public int Id { get; set; }

        [Required]
        public int Protein { get; set; }
        [Required]
        public int Fat { get; set; }
        [Required]
        public int Carbohydrate { get; set; }
        [Required]
        public int Calorie { get; set; }
    }
}
