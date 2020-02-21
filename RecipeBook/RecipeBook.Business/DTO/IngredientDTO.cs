using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBook.Business
{
    public class IngredientDTO
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string CustomAmount { get; set; }
    }
}
