using FluentValidation;
using popIT.FoodOrder.Core.Garnishes;

namespace popIT.FoodOrder.Application.Validations
{
	public class GarnishAddRequestValidator : AbstractValidator<Garnish>
	{
		public GarnishAddRequestValidator()
		{
			RuleFor(g => g.Name)
				.NotNull()
				.WithMessage("Гарнир не может быть null.")
				.Length(2, 30)
				.WithMessage("Название гарнира должно быть от 2 до 30 символов.");
		}
	}
}
