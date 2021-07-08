using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JiraProjectDetail
    {
        public JiraProjectDetail()
        {
            JiraIssue = new HashSet<JiraIssue>();
            JiraIssueLink = new HashSet<JiraIssueLink>();
            JiraSprintBacklog = new HashSet<JiraSprintBacklog>();
            JiraUser = new HashSet<JiraUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Discription { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<JiraIssue> JiraIssue { get; set; }
        public virtual ICollection<JiraIssueLink> JiraIssueLink { get; set; }
        public virtual ICollection<JiraSprintBacklog> JiraSprintBacklog { get; set; }
        public virtual ICollection<JiraUser> JiraUser { get; set; }
    }
}
