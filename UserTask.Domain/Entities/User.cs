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
        //TODO: Salary should be decimal
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        //TODO: Position should be enum
        public string Position { get; set; }
        public string Address { get; set; }
        //TODO: Phone sould be string
        public int Phone { get; set; }
    }
}
