using AutoMapper;
using RecipeBook.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Business
{
    public class RecipeService : Service, IRecipeService
    {
        public RecipeService(IMapper mapper, IUnitOfWork unit) : base(mapper, unit)
        {
        }

        public async Task AddAsync(RecipeDTO recipeDTO)
        {
            var recipe = mapper.Map<Recipe>(recipeDTO);
            recipe.Ingredients = mapper.Map<ICollection<Ingredient>>(recipeDTO.Ingredients);
            await unit.RecipeRepository.AddAsync(recipe);
            await unit.SaveChangesAsync();
        }

        public async Task DeleteAsync(int recipeId)
        {
            await unit.RecipeRepository.DeleteAsync(recipeId);
            await unit.SaveChangesAsync();
        }

        public async Task<IEnumerable<RecipeDTO>> GetAllAsync()
        {
            var recipes = await unit.RecipeRepository.GetAllAsync();
            return mapper.Map<IEnumerable<RecipeDTO>>(recipes);
        }

        public async Task<IEnumerable<RecipeDTO>> GetByUserAsync(int userId)
        {
            var recipes = await unit.RecipeRepository.GetByUserAsync(userId);
            return mapper.Map<IEnumerable<RecipeDTO>>(recipes);
        }

        public async Task<RecipeDTO> GetWithIngredientsAsync(int id)
        {
            var recipe = await unit.RecipeRepository.GetWithIngredientsAsync(id);
            var recipeDTO = mapper.Map<RecipeDTO>(recipe);
            recipeDTO.Ingredients = mapper.Map<ICollection<IngredientDTO>>(recipe.Ingredients);
            return recipeDTO;
        }

        public async Task UpdateAsync(RecipeDTO recipeDTO)
        {
            var recipe = mapper.Map<Recipe>(recipeDTO);
            unit.RecipeRepository.UpdateAsync(recipe);
            await unit.SaveChangesAsync();
        }
    }
}
