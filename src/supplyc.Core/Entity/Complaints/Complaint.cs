using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Complaints
{
    [Table("Supply_Complaint")]
    public class Complaint : FullAuditedEntity<int>
    {
        public int Number { get; set; }
        public string Complain { get; set; }
        public DateTime Date { get; set; }
        public string ComplainTo { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
