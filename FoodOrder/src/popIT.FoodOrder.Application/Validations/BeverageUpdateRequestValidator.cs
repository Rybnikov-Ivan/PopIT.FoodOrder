using FluentValidation;
using popIT.FoodOrder.Core.Beverages.Requests;

namespace popIT.FoodOrder.Application.Validations
{
	public class BeverageUpdateRequestValidator : AbstractValidator<BeverageUpdateRequest>
	{
		public BeverageUpdateRequestValidator()
		{
			RuleFor(b => b.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
			
			RuleFor(b => b.Price)
				.GreaterThan(0)
				.WithMessage("Цена должна быть больше нуля.");
		}
	}
}
