using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Complaints;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.ComplaintInformation.Dto
{
    [AutoMap(typeof(Complaint))]
   public class Dto_Complaint : EntityDto<int>
    {
        public int Number { get; set; }
        public string Complain { get; set; }
        public DateTime Date { get; set; }
        public string ComplainTo { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
