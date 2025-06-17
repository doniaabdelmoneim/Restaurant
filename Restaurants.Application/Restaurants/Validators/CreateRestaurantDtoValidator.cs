
using FluentValidation;
using Restaurants.Application.Restaurants.Dtos;

namespace Restaurants.Application.Restaurants.Validators
{
    public class CreateRestaurantDtoValidator:AbstractValidator<createRestaurantDto>
    {
        public CreateRestaurantDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(3, 100).WithMessage("Name must be between 3 and 100 characters.");
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.");
            RuleFor(x => x.category)
                .NotEmpty().WithMessage("Category is required.");
            RuleFor(x => x.contactEmail)
                .EmailAddress().WithMessage("Please provide a valid email address.")
                .When(x => !string.IsNullOrEmpty(x.contactEmail));
            RuleFor(x => x.contactNumber)
                .Matches(@"^\d{10}$").WithMessage("Please provide a valid phone number.")
                .When(x => !string.IsNullOrEmpty(x.contactNumber));
            RuleFor(x => x.city)
                .NotEmpty().WithMessage("City is required.")
                .When(x => !string.IsNullOrEmpty(x.city));
            RuleFor(x => x.street)
                .NotEmpty().WithMessage("Street is required.")
                .When(x => !string.IsNullOrEmpty(x.street));
            RuleFor(x => x.postalCode)
                .Matches(@"^\d{2}-\d{3}$").WithMessage("Please provide a valid postal code (xx-xxx).")
                .When(x => !string.IsNullOrEmpty(x.postalCode));


        }

    }
}
