using Hades.ServiceInterface.Engines;
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
        IDepositEngine _engine;

        public DepositHandler(IDepositEngine depositEngine)
        {
            _engine = depositEngine;
        }

        public DepositResponse Post(Deposit deposit)
        {
            try
            {
                DepositResponse response = _engine.ProcessDeposit(deposit.UserId, deposit.DepositType, deposit.DepositAmount);
                return response;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new DepositResponse();
            }

        }
    }
}
