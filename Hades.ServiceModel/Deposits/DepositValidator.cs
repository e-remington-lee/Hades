using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceModel.Deposits
{
    public class DepositValidator : AbstractValidator<Deposit>
    {
        public DepositValidator()
        {
            RuleFor(x => x.DepositAmount).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.DepositType).NotEmpty();
        }
    }
}
