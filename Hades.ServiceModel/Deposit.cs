using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceModel
{
   [Route("/deposit", "GET")]
    public class Deposit : IReturn<DepositResponse>
    {
        public int DepositId { get; set; }
        public decimal DepositAmount { get; set; }
    }

    public class DepositResponse
    {
        public int ResponseCode { get; set; }
    }
}
