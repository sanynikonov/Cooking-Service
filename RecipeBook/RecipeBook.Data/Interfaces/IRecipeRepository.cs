using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<Recipe>> GetAllAsync();
        Task<IEnumerable<Recipe>> GetByUserAsync(int userId);
        Task<Recipe> GetWithIngredientsAsync(int id);
        Task AddAsync(Recipe recipe);
        void UpdateAsync(Recipe recipe);
        Task DeleteAsync(int id);
    }
}
