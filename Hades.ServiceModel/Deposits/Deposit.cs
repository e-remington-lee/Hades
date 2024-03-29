﻿using Hades.ServiceModel.Deposits;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceModel
{
   [Route("/deposit", "POST")]
    public class Deposit : IReturn<DepositResponse>
    {
        public int UserId { get; set; }
        public decimal DepositAmount { get; set; }
        
        public DepositType DepositType { get; set; }
    }
}
