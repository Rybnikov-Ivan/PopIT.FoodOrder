using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Soups;
using System;
using System.Linq;

namespace popIT.FoodOrder.Infrastructure.Data
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using var context = new FoodOrderDbContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<FoodOrderDbContext>>());

			context.Database.Migrate();

			if(!context.Beverages.Any())
			{
				context.Beverages.AddRange(
					new Beverage { Name = "Компот" },
					new Beverage { Name = "Чай" },
					new Beverage { Name = "Сок" },
					new Beverage { Name = "Кофе" }
					);
			}

			if(!context.Meats.Any())
			{
				context.Meats.AddRange(
					new Meat { Name = "Котлета по-домашнему" },
					new Meat { Name = "Курица" },
					new Meat { Name = "Купаты" },
					new Meat { Name = "Шашлык" }
					);
			}

			if(!context.Soups.Any())
			{
				context.Soups.AddRange(
					new Soup { Name = "Борщ" },
					new Soup { Name = "Гороховый суп" },
					new Soup { Name = "Солянка" },
					new Soup { Name = "Щи" }
					);
			}

			if(!context.Garnishes.Any())
			{
				context.Garnishes.AddRange(
					new Garnish { Name = "Гречка" },
					new Garnish { Name = "Макароны" },
					new Garnish { Name = "Рис" },
					new Garnish { Name = "Пюре" }
					);
			}

			context.SaveChangesAsync();
		}
	}
}
