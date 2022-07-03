using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating_App.Data;
using Dating_App.Interfaces;
using Dating_App.Services;
using Microsoft.EntityFrameworkCore;

namespace Dating_App.Extentions
{
    public static class ApplicationServicesExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }   
    }
}