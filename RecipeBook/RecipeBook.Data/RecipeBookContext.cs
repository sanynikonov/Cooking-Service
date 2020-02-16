using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RecipeBook.Data
{
    internal class RecipeBookContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Product> Products { get; set; }

        public RecipeBookContext(DbContextOptions<RecipeBookContext> options) 
            : base(options)
        {
        }


    }
}
