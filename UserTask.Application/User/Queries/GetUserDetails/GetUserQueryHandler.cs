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
using UserTask.Application.User.Queries.GetUserDetails;

namespace UserTask.Application.User.Queries.GetUserDetails
{
    public class GetUserQueryHandler : IRequestHandler<GetUserDetails.GetUserDetailQuery, UserDetailsDto>
    {
        private readonly IUserDbContext _context;
        private readonly IMapper _mapper;
        public GetUserQueryHandler(IUserDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserDetailsDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(i => i.Id == request.Id);

            if (user == null) throw new NotFoundException(request.Id);

            var userDetailDto = _mapper.Map<UserDetailsDto>(user);

            return userDetailDto;
        }
    }
}
