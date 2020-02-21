using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RecipeBook.Business
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<IngredientDTO> Ingredients { get; set; }
        public string Instruction { get; set; }
        public DateTime DateOfCreation { get; set; }

        public RecipeDTO()
        {
            Ingredients = new Collection<IngredientDTO>();
        }
    }
}
