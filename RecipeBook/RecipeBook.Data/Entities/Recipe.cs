using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RecipeBook.Data
{
    public class Recipe
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public string Instruction { get; set; }
        public DateTime DateOfCreation { get; set; }

        public Recipe()
        {
            Ingredients = new Collection<Ingredient>();
        }
    }
}
