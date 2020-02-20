using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecipeBook.Data
{
    public class Ingredient
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string CustomAmount { get; set; }
    }
}
