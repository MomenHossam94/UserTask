using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UserTask.Application.Common.Interfaces;
using UserTask.Domain.Entities;

namespace UserTask.Presistence
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<UserDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserDbContext>(provider => provider.GetService<UserDbContext>());
            return services;

        }
    }
}
