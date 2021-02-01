using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Queries.GetUserDetails
{
    public class GetUserDetailQueryValidator : AbstractValidator<GetUserDetailQuery>
    {
        public GetUserDetailQueryValidator()
        {
            RuleFor(i => i.Id).GreaterThan(0);
        }
    }
}
