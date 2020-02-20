using RecipeBook.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Business
{
    public class Service : IService
    {
        private IUnitOfWork unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }

        public async Task Do()
        {
            await unitOfWork.RecipeRepository.GetAllAsync();
        }
    }
}
