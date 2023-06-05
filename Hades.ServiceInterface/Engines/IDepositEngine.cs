using Hades.ServiceModel;
using Hades.ServiceModel.Deposits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceInterface.Engines
{
    public interface IDepositEngine
    {
        public Task<DataResponse<DepositResponse>> ProcessDeposit(int userId, DepositType depositType, decimal depositAmount);
    }
}
