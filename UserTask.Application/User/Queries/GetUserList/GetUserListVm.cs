using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Queries.GetUserList
{
    public class GetUserListVm
    {
        public IList<UserDto> Users { get; set; }
    }
}
