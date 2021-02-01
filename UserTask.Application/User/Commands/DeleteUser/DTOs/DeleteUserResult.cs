using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Commands.DeleteUser
{
    public class DeleteUserResult
    {
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
    }
}
