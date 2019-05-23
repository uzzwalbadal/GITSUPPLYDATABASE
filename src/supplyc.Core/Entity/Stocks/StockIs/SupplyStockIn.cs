
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Stocks.StockIs
{
    [Table("Supply_SupplyStockIns")]
    public class SupplyStockIn : FullAuditedEntity<int>
    {
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Stocked_From { get; set; }
    }
}
