using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBook.Data
{
    public static class ServiceCollectionDALExtension
    {
        public static void ConfigureDAL(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<RecipeBookContext>(
                options => options.UseSqlServer(connectionString));
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<RecipeBookContext>();
        }
    }
}
