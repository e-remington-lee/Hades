using System;
using ServiceStack;

namespace Hades.ServiceModel.Deposits
{
    public class DepositResponse : IHasResponseStatus
    {
        public string TransactionId { get; set; }
        public int ResponseCode { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public string StatusMessage { get; set; }
    }
}
