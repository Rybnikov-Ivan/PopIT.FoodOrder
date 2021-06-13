using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Soups;
using System;
using System.Linq;
using popIT.FoodOrder.Core.Students;
using popIT.FoodOrder.Core.Orders;

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
					new Beverage { Name = "Компот", Price = 43 },
					new Beverage { Name = "Чай", Price = 37 },
					new Beverage { Name = "Сок", Price = 68 },
					new Beverage { Name = "Кофе", Price = 43 }
					);
			}

			if(!context.Meats.Any())
			{
				context.Meats.AddRange(
					new Meat { Name = "Котлета по-домашнему", Price = 25 },
					new Meat { Name = "Курица", Price = 62 },
					new Meat { Name = "Купаты", Price = 98 },
					new Meat { Name = "Шашлык", Price = 100 }
					);
			}

			if(!context.Soups.Any())
			{
				context.Soups.AddRange(
					new Soup { Name = "Борщ", Price = 50 },
					new Soup { Name = "Гороховый суп", Price = 8 },
					new Soup { Name = "Солянка", Price = 13 },
					new Soup { Name = "Щи", Price = 43 }
					);
			}

			if(!context.Garnishes.Any())
			{
				context.Garnishes.AddRange(
					new Garnish { Name = "Гречка", Price = 10 },
					new Garnish { Name = "Макароны", Price = 5 },
					new Garnish { Name = "Рис", Price = 30 },
					new Garnish { Name = "Пюре", Price = 12 }
					);
			}

			if(!context.Students.Any())
			{
				context.Students.AddRange(
					new Student()
					{
						Name = "Кирилл",
						StudentTicket = "2020-65156"
					},
					new Student
					{
						Name = "Александр",
						StudentTicket = "2020-23166"
					},
					new Student
					{
						Name = "Алексей",
						StudentTicket = "2020-98452"
					},
					new Student
					{
						Name = "Иван",
						StudentTicket = "2020-12225"
					}
				);
			}
			
			context.SaveChanges();
		}
	}
}
