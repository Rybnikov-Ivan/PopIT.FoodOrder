using FluentValidation;
using popIT.FoodOrder.Core.Soups.Requests;

namespace popIT.FoodOrder.Application.Validations
{
	public class SoupUpdateRequestValidator : AbstractValidator<SoupUpdateRequest>
	{
		public SoupUpdateRequestValidator()
		{
			RuleFor(b => b.Name)
				.NotNull()
				.WithMessage("Напиток не может быть null.")
				.Length(2, 30)
				.WithMessage("Название напитка должно быть от 2 до 30 символов.");
		}
	}
}
