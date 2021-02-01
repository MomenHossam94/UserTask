using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserTask.Application.Common.Exceptions;
using UserTask.Application.Common.Interfaces;

namespace UserTask.Application.User.Commands.UpdateUser
{
    public class UpdateUserCommandHander : IRequestHandler<UpdateUserCommand, UpdateUserResult>
    {
        private readonly IUserDbContext _context;
        private readonly IMapper _mapper;


        public UpdateUserCommandHander(IUserDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UpdateUserResult> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
           var user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(i=>i.Id==request.Id);
            if (user == null)
            {
                throw new NotFoundException(request.Id);
            }

            var result = new UpdateUserResult();
            //TODO: use Automapper
            var userModel = _mapper.Map<Domain.Entities.User>(request);

            _context.Users.Update(userModel);

            if (await _context.SaveChangesAsync(cancellationToken) > 0)
            {
                result.Id = request.Id;
                result.IsUpdated = true;
            }

            return result;
        }
    }
}
