﻿using Microsoft.Extensions.DependencyInjection;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Soups;
using popIT.FoodOrder.Infrastructure.Data.Repositories;

namespace popIT.FoodOrder.Application.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBeverageRepository, BeverageRepository>();
            services.AddScoped<IGarnishRepository, GarnishRepository>();
            services.AddScoped<IMeatRepository, MeatRepository>();
            services.AddScoped<ISoupRepository, SoupRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}