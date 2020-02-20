using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Business
{
    public interface IService : IDisposable
    {
        Task Do();
    }
}
