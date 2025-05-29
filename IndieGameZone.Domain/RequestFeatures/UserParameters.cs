using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Domain.RequestFeatures
{
    public class UserParameters : RequestParameters
    {
        public string SearchName { get; set; } = string.Empty;
    }
}
