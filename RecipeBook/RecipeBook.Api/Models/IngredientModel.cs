using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Api.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public string CustomAmount { get; set; }
    }
}
