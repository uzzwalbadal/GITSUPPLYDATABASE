using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Supplys

{
    [Table("Supply_Supply")]
    public class Supply : FullAuditedEntity<int>
    {
        public string Product { get; set; }
        public string SuppliedTo { get; set; }
        public string Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Validity { get; set; }
    }
}
