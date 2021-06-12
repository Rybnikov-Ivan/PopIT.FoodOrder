using FluentValidation;
using popIT.FoodOrder.Core.Meats;

namespace popIT.FoodOrder.Application.Validations
{
	public class MeatUpdateRequestValidator : AbstractValidator<Meat>
	{
		public MeatUpdateRequestValidator()
		{
			RuleFor(b => b.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
		}
	}
}
