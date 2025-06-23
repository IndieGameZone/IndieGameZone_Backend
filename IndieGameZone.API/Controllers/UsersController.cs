using IndieGameZone.Application;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public UsersController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUsers([FromQuery] UserParameters userParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.UserService.GetUsers(userParameters, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.users);
        }

        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> GetUser([FromRoute] Guid userId, CancellationToken ct)
        {
            var user = await serviceManager.UserService.GetUserById(userId.ToString(), ct);
            return Ok(user);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateUser([FromBody] UserForCreationDto userForCreationDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await serviceManager.UserService.CreateUser(userForCreationDto, true, ct);
            return StatusCode(201);
        }

        [HttpPut("{userId:guid}")]
        [Authorize]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid userId, [FromForm] UserForUpdateDto userForUpdateDto, CancellationToken ct)
        {
            await serviceManager.UserService.UpdateUser(userId, userForUpdateDto, ct);
            return NoContent();
        }

        [HttpPatch("{userId:guid}/username")]
        public async Task<IActionResult> UpdateUsername([FromRoute] Guid userId, [FromBody] UserForUpdateUsernameDto userForUpdateUsernameDto, CancellationToken ct)
        {
            await serviceManager.UserService.UpdateUsername(userId, userForUpdateUsernameDto.NewUsername, ct);
            return NoContent();
        }

        [HttpPatch("{userId:guid}/password")]
        [Authorize]
        public async Task<IActionResult> UpdatePassword([FromRoute] Guid userId, [FromBody] UserForUpdatePasswordDto userForUpdatePasswordDto, CancellationToken ct)
        {
            await serviceManager.UserService.UpdatePassword(userId, userForUpdatePasswordDto, ct);
            return NoContent();
        }
        [HttpPatch("{userId:guid}/birthday")]
        [Authorize]
        public async Task<IActionResult> UpdateBirthday([FromRoute] Guid userId, [FromBody] UserForUpdateBirthdayDto dto, CancellationToken ct)
        {
            await serviceManager.UserService.UpdateBirthday(userId, dto.Birthday, ct);
            return NoContent();
        }
    }
}
