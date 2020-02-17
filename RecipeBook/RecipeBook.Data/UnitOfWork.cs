using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRecipeRepository RecipeRepository => throw new NotImplementedException();

        public IUserRepository UserRepository => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
