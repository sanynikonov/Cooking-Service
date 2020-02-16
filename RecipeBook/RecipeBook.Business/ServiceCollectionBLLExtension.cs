using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using RecipeBook.Data;

namespace RecipeBook.Business
{
    public static class ServiceCollectionBLLExtension
    {
        public static void ConfigureBLL(this IServiceCollection services, string connectionString)
        {
            services.ConfigureDAL(connectionString);
        }
    }
}
