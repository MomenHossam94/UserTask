using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserTask.Application.Common.Interfaces;

namespace UserTask.Application.User.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResult>
    {
        private readonly IUserDbContext _userDbContext;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUserDbContext userDbContext, IMapper mapper)
        {
            _userDbContext = userDbContext;
            _mapper = mapper;
        }
        public async Task<CreateUserResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.Entities.User>(request);
            _userDbContext.Users.Add(user);
            if (await _userDbContext.SaveChangesAsync(cancellationToken) > 0)
            {
                return new CreateUserResult { Id = user.Id, Success = true };
            }


            return new CreateUserResult { Success = false };

        }
    }
}
