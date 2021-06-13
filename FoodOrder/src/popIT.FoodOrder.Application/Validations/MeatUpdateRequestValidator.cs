using FluentValidation;
using popIT.FoodOrder.Core.Meats.Requests;

namespace popIT.FoodOrder.Application.Validations
{
	public class MeatUpdateRequestValidator : AbstractValidator<MeatUpdateRequest>
	{
		public MeatUpdateRequestValidator()
		{
			RuleFor(m => m.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
			
			RuleFor(m => m.Price)
				.GreaterThan(0)
				.WithMessage("Цена должна быть больше нуля.");
		}
	}
}
