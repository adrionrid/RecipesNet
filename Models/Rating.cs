using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Required]
        public Entry Entry { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public bool Value { get; set; }
    }

    public static class RatingExtention
    {
        public static int Positive(this ICollection<Rating> items)
        {
            return items.Where(x => x.Value).Count();
        }
        public static int Negative(this ICollection<Rating> items)
        {
            return items.Where(x => !x.Value).Count();
        }
    }
}
