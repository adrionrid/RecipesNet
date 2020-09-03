using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Models
{
    public class Entry
    {
        public int Id { get; set; }

        [Required]
        public IdentityUser Author { get; set; }
        public int AuthorId { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
