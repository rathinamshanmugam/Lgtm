using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JiraIssue
    {
        public JiraIssue()
        {
            JiraTimeSheet = new HashSet<JiraTimeSheet>();
        }

        public int Id { get; set; }
        public int JiraProjectDetailId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public int JiraUserId { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual JiraProjectDetail JiraProjectDetail { get; set; }
        public virtual JiraUser JiraUser { get; set; }
        public virtual ICollection<JiraTimeSheet> JiraTimeSheet { get; set; }
    }
}
