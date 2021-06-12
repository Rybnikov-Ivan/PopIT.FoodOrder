using FluentValidation;
using popIT.FoodOrder.Core.Soups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Application.Validations
{
	public class SoupAddRequestValidator : AbstractValidator<Soup>
	{
		public SoupAddRequestValidator()
		{
			RuleFor(s => s.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
		}
	}
}
