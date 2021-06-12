using FluentValidation;
using popIT.FoodOrder.Core.Garnishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Application.Validations
{
	public class GarnishUpdateRequestValidator : AbstractValidator<Garnish>
	{
		public GarnishUpdateRequestValidator()
		{
			RuleFor(g => g.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
		}
	}
}
