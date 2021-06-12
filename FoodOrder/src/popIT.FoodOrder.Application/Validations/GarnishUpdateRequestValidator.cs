using FluentValidation;
using popIT.FoodOrder.Core.Garnishes.Requests;

namespace popIT.FoodOrder.Application.Validations
{
	public class GarnishUpdateRequestValidator : AbstractValidator<GarnishUpdateRequest>
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
