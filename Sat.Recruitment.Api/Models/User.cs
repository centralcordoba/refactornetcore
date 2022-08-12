using FluentValidation;

namespace Sat.Recruitment.Api.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string UserType { get; set; }
        public decimal Money { get; set; }
    }

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(model => model.Name).NotEmpty().WithMessage("The name is required");
            RuleFor(model => model.Email).NotEmpty().WithMessage("The email is required");
            RuleFor(model => model.Address).NotEmpty().WithMessage("The address is required");
            RuleFor(model => model.Phone).NotEmpty().WithMessage("The phone is required");
        }
    }
}
