using Hades.ServiceModel;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceInterface
{
    public class DepositHandler : Service
    {
        public DepositResponse Post(Deposit deposit)
        {
            string transactionId = "abcdefg";
            var response = new DepositResponse() { ResponseCode = 200, TransactionId = transactionId };
            return response;

        }
    }
}
