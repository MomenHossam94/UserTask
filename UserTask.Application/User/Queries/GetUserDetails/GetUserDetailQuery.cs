using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Queries.GetUserDetails
{
    public class GetUserDetailQuery : IRequest<UserDetailsDto>
    {
        public int Id { get; set; }
    }
}
