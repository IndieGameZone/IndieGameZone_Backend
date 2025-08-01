using IndieGameZone.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reports
{
    public class ReportForUpdateStatusDto
    {
        public string? ReviewMessage { get; init; }
    }
}
