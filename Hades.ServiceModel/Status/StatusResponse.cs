using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Hades.ServiceModel.Status
{
    public class StatusResponse : IHasResponseStatus
    {
        public string StatusMessage { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
    }
}
