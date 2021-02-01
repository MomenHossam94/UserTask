using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UserTask.Application.User.Commands.DeleteUser
{
    public class DeleteCommandValidator:AbstractValidator<DeleteUserCommand>
    {
        public DeleteCommandValidator()
        {
            RuleFor(i => i.Id).GreaterThan(0);
        }
    }
}
