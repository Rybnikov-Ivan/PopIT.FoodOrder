using FluentValidation;
using popIT.FoodOrder.Core.Orders.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Application.Validations
{
	public class OrderAddRequestValidator : AbstractValidator<OrderAddRequest>
	{
		public OrderAddRequestValidator()
		{
			RuleFor(o => o.BeverageId)
				.GreaterThanOrEqualTo(0)
				.WithMessage("Идентификатор должен быть больше либо равен 0.");

			RuleFor(o => o.GarnishId)
				.GreaterThanOrEqualTo(0)
				.WithMessage("Идентификатор должен быть больше либо равен 0.");

			RuleFor(o => o.MeatId)
							.GreaterThanOrEqualTo(0)
							.WithMessage("Идентификатор должен быть больше либо равен 0.");

			RuleFor(o => o.SoupId)
							.GreaterThanOrEqualTo(0)
							.WithMessage("Идентификатор должен быть больше либо равен 0.");
		}
	}
}
