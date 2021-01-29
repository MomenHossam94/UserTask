using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTask.Application.User.Commands.CreateUser;
using UserTask.Application.User.Commands.DeleteUser;
using UserTask.Application.User.Commands.UpdateUser;
using UserTask.Application.User.Queries.GetUserDetails;
using UserTask.Application.User.Queries.GetUserList;

namespace UserTask.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
  

    public class UserController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("Get")]
    
        public async Task<IActionResult> Get(int id)
        {
            var result = await Mediator.Send(new GetUserDetailQuery {  Id =id});

            return Ok(result);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await Mediator.Send(new GetUserListQuery());

            return Ok(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("Create")]
        
        public async Task<IActionResult> Create([FromBody]CreateUserCommand command)
        {
            var result = await Mediator.Send(command);

            return Ok(result);
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("Update")]
        public async Task<IActionResult> Update([FromBody]UpdateUserCommand command)
        {
            var result = await Mediator.Send(command);

            return Ok(result);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Send(new DeleteUserCommand { Id=id});

            return Ok(result);
        }
    }
}