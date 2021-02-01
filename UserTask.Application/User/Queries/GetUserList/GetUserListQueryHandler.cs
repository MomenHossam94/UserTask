using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserTask.Application.Common.Interfaces;

namespace UserTask.Application.User.Queries.GetUserList
{
    public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, GetUserListDto>
    {
        private readonly IUserDbContext _context;
        private readonly IMapper _mapper;

        public GetUserListQueryHandler(IUserDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetUserListDto> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var userList = await _context.Users.ToListAsync();

            var userDto = new GetUserListDto();

            var userListDto = _mapper.Map<List<UserDto>>(userList);

            userDto.Users = userListDto;

            return userDto;
        }
    }
}
