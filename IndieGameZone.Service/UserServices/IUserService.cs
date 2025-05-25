using IndieGameZone.Domain.RequestsAndResponses.Requests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.UserServices
{
    public interface IUserService
    {
        Task CreateUser(UserForCreationDto userForCreationDto, CancellationToken ct = default);
    }
}
