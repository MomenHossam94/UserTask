using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.Common.Exceptions
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(int id):base("User with Id = "+id+"Not Found" )
        {

        }
    }
}
