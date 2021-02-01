using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Commands.UpdateUser
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(i => i.Id).GreaterThan(0);
            RuleFor(i => i.Name).MinimumLength(5).MaximumLength(150).NotEmpty();
            RuleFor(i => i.Address).MinimumLength(5).MaximumLength(160);
            RuleFor(i => i.Age).GreaterThan(0);
            RuleFor(i => i.Phone).MinimumLength(4).NotEmpty();
        }
    }
}
