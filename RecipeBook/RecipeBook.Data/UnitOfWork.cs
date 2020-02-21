using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private RecipeBookContext context;

        public UnitOfWork(IRecipeRepository recipeRepository, IUserRepository userRepository, RecipeBookContext context)
        {
            this.RecipeRepository = recipeRepository;
            this.UserRepository = userRepository;
            this.context = context;
        }

        public IRecipeRepository RecipeRepository { get; }

        public IUserRepository UserRepository { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
