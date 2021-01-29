using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
