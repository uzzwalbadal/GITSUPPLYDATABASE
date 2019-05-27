using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactions.Dto
{
    public class Dto_SupplyTranasctionDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public string Type { get; set; }
        public int SupplytransactiontypeId { get; set; }
        public string SupplytransactiontypeName { get; set; }
    }
}
