using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Commands.CreateUser
{
    public class CreateUserCommandValidator:AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(i => i.Name).MaximumLength(50).NotEmpty();
            RuleFor(i => i.Address).MaximumLength(60);
            RuleFor(i => i.Age).NotEmpty();
            RuleFor(i => i.Phone).NotEmpty();

        }
    }
}
