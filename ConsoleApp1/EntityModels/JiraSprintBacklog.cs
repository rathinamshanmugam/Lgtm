using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JiraSprintBacklog
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? JiraProjectDetailId { get; set; }
        public int? JiraBackLogId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual JiraBackLog JiraBackLog { get; set; }
        public virtual JiraProjectDetail JiraProjectDetail { get; set; }
    }
}
