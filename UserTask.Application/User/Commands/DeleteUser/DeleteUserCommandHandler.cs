using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserTask.Application.Common.Exceptions;
using UserTask.Application.Common.Interfaces;

namespace UserTask.Application.User.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserResult>
    {
        private readonly IUserDbContext _context;
        public DeleteUserCommandHandler(IUserDbContext context)
        {
            _context = context;
        }
        public async Task<DeleteUserResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(i => i.Id == request.Id);

            if (user == null)
            {
                throw new NotFoundException(request.Id);
            }

            _context.Users.Remove(user);

            if (await _context.SaveChangesAsync(cancellationToken) > 0)
            {
                return new DeleteUserResult { Id = request.Id, IsDeleted = true };
            }

            return new DeleteUserResult { Id = request.Id, IsDeleted = false };

        }
    }
}
