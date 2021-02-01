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
        
        public UpdateUserCommandHander(IUserDbContext context)
        {
            _context = context;
        }
        public async Task<UpdateUserResult> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(i=>i.Id==request.Id);
            if (user == null) throw new  NotFoundException(request.Id);
          
            //TODO: use Automapper
            user.Name = request.Name;
            user.JoiningDate = request.JoiningDate;
            user.Phone = request.Phone;
            user.Position = request.Position;
            user.Salary = request.Salary;
            user.Age = request.Age;
            user.Address = request.Address;
            _context.Users.Update(user);
            if(await _context.SaveChangesAsync(cancellationToken)>0)
            {
                return new UpdateUserResult {Id = request.Id,IsUpdated=true };
            }
            return new UpdateUserResult { Id = request.Id, IsUpdated = false };
        }
    }
}
