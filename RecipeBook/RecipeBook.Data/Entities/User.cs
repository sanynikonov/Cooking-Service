using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace RecipeBook.Data
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public User()
        {
            Recipes = new Collection<Recipe>();
        }
    }
}
