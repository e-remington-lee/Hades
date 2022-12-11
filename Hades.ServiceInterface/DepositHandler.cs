using FluentValidation;
using FluentValidation.Results;
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
                (bool hasErrors, ValidationResult validationResults) = await GenericValidator.ValidateRequest<Deposit>(deposit, abstractValidator);
                if (hasErrors)
                {
                    base.Response.StatusCode = 400;
                    return new DepositResponse()
                    {
                        StatusMessage = validationResults.Errors.ToString()
                    };
                }
                DataResponse<DepositResponse> response = await _engine.ProcessDeposit(deposit.UserId, deposit.DepositType, deposit.DepositAmount);
                return response.Data;
            } 
            catch (Exception ex)
            {
                base.Response.StatusCode = ex.ToStatusCode();
                Console.WriteLine(ex.Message);
                return new DepositResponse() {  StatusMessage = ex.Message};
            }

        }
    }
}
