using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JiraUser
    {
        public JiraUser()
        {
            JiraIssue = new HashSet<JiraIssue>();
        }

        public int Id { get; set; }
        public string Surename { get; set; }
        public string Forename { get; set; }
        public string Email { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int JiraProjectDetailId { get; set; }

        public virtual JiraProjectDetail JiraProjectDetail { get; set; }
        public virtual ICollection<JiraIssue> JiraIssue { get; set; }
    }
}
