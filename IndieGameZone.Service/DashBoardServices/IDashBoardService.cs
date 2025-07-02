using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.DashBoardServices
{
    public interface IDashBoardService
    {
        Task<IEnumerable<GameForListReturnDto>> GetTop10MostDownloadedGamesAsync(CancellationToken ct = default);
    }
}
