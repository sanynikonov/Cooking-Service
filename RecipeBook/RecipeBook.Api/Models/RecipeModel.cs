using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Api.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public ICollection<IngredientModel> Ingredients { get; set; }
        [Required]
        public string Instruction { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }

        public RecipeModel()
        {
            Ingredients = new Collection<IngredientModel>();
        }
    }
}
