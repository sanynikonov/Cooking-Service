using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    internal class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeBookContext context;
        private readonly DbSet<Recipe> recipes;

        public RecipeRepository(RecipeBookContext context)
        {
            this.context = context;
            recipes = context.Recipes;
        }

        public async Task AddAsync(Recipe recipe)
        {
            if (recipe == null)
                throw new NullReferenceException();

            await recipes.AddAsync(recipe);
        }

        public async Task DeleteAsync(int id)
        {
            var recipe = await context.Recipes.FindAsync(id);
            if (recipe != null)
                recipes.Remove(recipe);
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            return await recipes.ToListAsync();
        }

        public async Task<IEnumerable<Recipe>> GetByUserAsync(int userId)
        {
            var user = await context.Users
                .Include(u => u.Recipes)
                .SingleOrDefaultAsync(x => x.Id == userId);
            
            return user.Recipes;
        }

        public async Task<Recipe> GetWithIngredientsAsync(int id)
        {
            return await recipes.Include(r => r.Ingredients)
                .SingleOrDefaultAsync(r => r.Id == id);
        }

        public void UpdateAsync(Recipe recipe)
        {
            context.Entry(recipe).State = EntityState.Modified;
        }
    }
}
