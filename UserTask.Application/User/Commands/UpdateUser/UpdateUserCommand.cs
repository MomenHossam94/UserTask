using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using UserTask.Application.Common.Mapping;
using UserTask.Domain.Entities;
using UserTask.Domain.Enums.User;

namespace UserTask.Application.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<UpdateUserResult> ,IMapFrom<Domain.Entities.User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public Position Position { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.User, User.Commands.UpdateUser.UpdateUserCommand>().ReverseMap();

        }
    }
}
