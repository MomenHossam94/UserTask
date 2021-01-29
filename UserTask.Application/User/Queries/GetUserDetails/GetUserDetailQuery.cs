using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Queries.GetUserDetails
{
    public class GetUserDetailQuery:IRequest<UserDetailsVm>
    {
        public int Id { get; set; }
    }
}
