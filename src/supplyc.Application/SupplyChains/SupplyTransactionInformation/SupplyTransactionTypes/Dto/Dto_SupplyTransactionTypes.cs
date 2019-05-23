using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.SupplyTransactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactionTypes.Dto
{
    [AutoMap(typeof(Supplytransactiontype))]
    public class Dto_SupplyTransactionTypes : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
