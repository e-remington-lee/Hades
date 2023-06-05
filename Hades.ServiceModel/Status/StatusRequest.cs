using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Hades.ServiceModel.Status
{
    [Route("/status", "GET")]
    public class StatusRequest : IReturn<StatusResponse>
    {
    }
}
