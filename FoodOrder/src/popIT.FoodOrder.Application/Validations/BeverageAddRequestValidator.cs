using FluentValidation;
using popIT.FoodOrder.Core.Beverages.Requests;

namespace popIT.FoodOrder.Application.Validations
{
	public class BeverageAddRequestValidator : AbstractValidator<BeverageAddRequest>
	{
		public BeverageAddRequestValidator()
		{
			RuleFor(b => b.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
		}
	}
}
