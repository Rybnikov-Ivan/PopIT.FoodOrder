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
			
			if(!context.Orders.Any())
			{
				context.Orders.AddRange(
					new Order
					{
						BeverageId = context.Beverages.OrderBy(b => b.Name).First().Id,
						GarnishId = context.Garnishes.OrderBy(b => b.Name).First().Id,
						MeatId = context.Meats.OrderBy(b => b.Name).First().Id,
						SoupId = context.Soups.OrderBy(b => b.Name).First().Id,
						OrderTime = DateTime.Now,
						IsСompleted = false
					},
					new Order
					{
						BeverageId = context.Beverages.OrderBy(b => b.Name).First().Id,
						GarnishId = context.Garnishes.OrderBy(b => b.Name).Last().Id,
						MeatId = context.Meats.OrderBy(b => b.Name).First().Id,
						SoupId = context.Soups.OrderBy(b => b.Name).Last().Id,
						OrderTime = DateTime.Now,
						IsСompleted = true
					},
					new Order
					{
						BeverageId = context.Beverages.OrderBy(b => b.Name).Last().Id,
						GarnishId = context.Garnishes.OrderBy(b => b.Name).Last().Id,
						MeatId = context.Meats.OrderBy(b => b.Name).Last().Id,
						SoupId = context.Soups.OrderBy(b => b.Name).Last().Id,
						OrderTime = DateTime.Now.AddDays(-1),
						IsСompleted = false
					},
					new Order
					{
						BeverageId = context.Beverages.OrderBy(b => b.Name).Last().Id,
						GarnishId = context.Garnishes.OrderBy(b => b.Name).First().Id,
						MeatId = context.Meats.OrderBy(b => b.Name).Last().Id,
						SoupId = context.Soups.OrderBy(b => b.Name).First().Id,
						OrderTime = DateTime.Now.AddDays(-1),
						IsСompleted = true
					});
			}

			context.SaveChanges();
		}
	}
}
