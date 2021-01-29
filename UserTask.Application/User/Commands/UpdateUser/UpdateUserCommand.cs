using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTask.Application.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<UpdateUserResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.User, User.Commands.UpdateUser.UpdateUserCommand>().ReverseMap();

        }
    }
}
