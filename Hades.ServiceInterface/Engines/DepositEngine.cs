using Hades.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceInterface.Engines
{
    public class DepositEngine : IDepositEngine
    {
        public DepositResponse ProcessDeposit(int userId, DepositType depositType, decimal depositAmount)
        {
            Console.WriteLine($"userID {userId}, depositType {depositType}, amount {depositAmount}");
            return new DepositResponse
            {
                ResponseCode = 200,
                TransactionId = Guid.NewGuid().ToString()
            };
        }

        
    }
}
