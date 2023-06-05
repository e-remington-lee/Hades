using Hades.ServiceModel;
using Hades.ServiceModel.Deposits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceInterface.Engines
{
    public class DepositEngine : IDepositEngine
    {
        public async Task<DataResponse<DepositResponse>> ProcessDeposit(int userId, DepositType depositType, decimal depositAmount)
        {
            Console.WriteLine($"userID {userId}, depositType {depositType}, amount {depositAmount}");
            var response = new DepositResponse
            {
                ResponseCode = 200,
                TransactionId = Guid.NewGuid().ToString()
            };
            return new DataResponse<DepositResponse> { Data = response, Status = 200 };
        }
    }
}
