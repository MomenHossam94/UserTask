using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UserTask.Application.User.Commands.CreateUser;

namespace UserTask.Application.User.Commands.DeleteUser
{
    public class DeleteUserCommand:IRequest<DeleteUserResult>
    {
        public int Id { get; set; }
    }
}
