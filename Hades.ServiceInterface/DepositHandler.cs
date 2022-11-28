using FluentValidation;
using Hades.ServiceInterface.Engines;
using Hades.ServiceModel;
using Hades.ServiceModel.Deposits;
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

        public async Task<DepositResponse> Post(Deposit deposit)
        {
            try
            {
                AbstractValidator<Deposit> abstractValidator = new DepositValidator();
                var result = await abstractValidator.ValidateAsync(deposit);
                if (result.Errors.Any())
                {
                    Console.Error.WriteLine($"Request has the following errors: \n{result}");
                    return new DepositResponse();
                }

                DataResponse<DepositResponse> response = await _engine.ProcessDeposit(deposit.UserId, deposit.DepositType, deposit.DepositAmount);

                return response.Data;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new DepositResponse();
            }

        }
    }
}
