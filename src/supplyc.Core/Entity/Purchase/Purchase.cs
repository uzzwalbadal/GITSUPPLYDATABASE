using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Purchase
{
    [Table("Supply_Purchases")]
    public class Purchase : FullAuditedEntity<int>
    {
        public string RefName { get; set; }

        public string Date { get; set; }
        public string BatchId { get; set; }


    }
}
