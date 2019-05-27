using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.OrderTrackings
{
    [Table("Supply_OrderTrackings")]
    public class OrderTracking : FullAuditedEntity<int>
    {
        public int Quantity { get; set; }

        public DateTime Date { get; set; }
        public string OrderedBy { get; set; }
        public string Validity { get; set; }

    }
}
