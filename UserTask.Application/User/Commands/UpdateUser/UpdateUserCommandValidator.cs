using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Commands.UpdateUser
{
    public class UpdateUserCommandValidator:AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(i => i.Id).NotEmpty();
            RuleFor(i => i.Name).MaximumLength(50).NotEmpty();
            RuleFor(i => i.Address).MaximumLength(60);
            RuleFor(i => i.Age).NotEmpty();
            RuleFor(i => i.Phone).NotEmpty();
        }
    }
}
