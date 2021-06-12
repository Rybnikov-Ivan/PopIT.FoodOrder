﻿using Microsoft.Extensions.DependencyInjection;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Soups;

namespace popIT.FoodOrder.Application.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBeverageService, BeverageService>();
            services.AddScoped<IGarnishService, GarnishService>();
            services.AddScoped<IMeatService, MeatService>();
            services.AddScoped<ISoupService, SoupService>();

            return services;
        }
    }
}