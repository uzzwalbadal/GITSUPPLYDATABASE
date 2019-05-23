using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Customers
{
    [Table("Supply_CustomerType")]
    public class CustomerType : FullAuditedEntity<int>
    {
        public string Name { get; set; }
    }
}
