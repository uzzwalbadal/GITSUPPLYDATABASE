using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.SupplyTransactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactions.Dto
{
    [AutoMap(typeof(Supplytransaction))]
    public class Dto_SupplyTransaction : EntityDto<int>
    {
        public string Name { get; set; }

        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public string Type { get; set; }
        public int SupplytransactiontypeId { get; set; }
    }
}
