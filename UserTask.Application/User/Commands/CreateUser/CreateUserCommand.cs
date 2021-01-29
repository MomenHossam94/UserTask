using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UserTask.Application.Common.Mapping;

namespace UserTask.Application.User.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<CreateUserResult>,IMapFrom<Domain.Entities.User>
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.User,User.Commands.CreateUser.CreateUserCommand>().ReverseMap();
                
        }

    }
}
