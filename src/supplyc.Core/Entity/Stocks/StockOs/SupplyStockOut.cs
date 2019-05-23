using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Stocks.StockOs
{
    [Table("Supply_SupplyStockOuts")]
    public class SupplyStockOutt: FullAuditedEntity<int>
    {
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Stocked_To { get; set; }
    }
}
