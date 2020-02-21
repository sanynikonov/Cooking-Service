using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Business
{
    public interface IRecipeService
    {
        Task<IEnumerable<RecipeDTO>> GetAllAsync();
        Task<IEnumerable<RecipeDTO>> GetByUserAsync(int userId);
        Task<RecipeDTO> GetWithIngredientsAsync(int id);
        Task AddAsync(RecipeDTO recipe);
        Task DeleteAsync(int recipeId);
        Task UpdateAsync(RecipeDTO recipe);
    }
}
