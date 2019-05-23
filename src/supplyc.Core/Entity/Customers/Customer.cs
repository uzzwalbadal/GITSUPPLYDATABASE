using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Customers
{
    [Table("Supply_Customers")]
    public class Customer : FullAuditedEntity<int>
    {
        public string Name { get; set; }

        public string Type { get; set; }
        public string Location { get; set; }
        public int Contact { get; set; }

        
    }
}
