using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Models
{
    public class RecipeEntry
    {
        public int Id { get; set; }

        [Required]
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }

        [Required]
        public Entry Entry { get; set; }
        public int EntryId { get; set; }

        public RecipeEntry(int RecipeId, int EntryId)
        {
            this.RecipeId = RecipeId;
            this.EntryId = EntryId;
        }
    }
}
