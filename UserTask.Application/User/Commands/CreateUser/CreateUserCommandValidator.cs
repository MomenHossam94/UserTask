using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(i => i.Name).MinimumLength(5).MaximumLength(150).NotEmpty();
            RuleFor(i => i.Address).MinimumLength(5).MaximumLength(160);
            RuleFor(i => i.Age).GreaterThan(0);
            RuleFor(i => i.Phone).MinimumLength(4).NotEmpty();

        }
    }
}
