using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JiraTimeSheet
    {
        public int Id { get; set; }
        public int JiraIssueId { get; set; }
        public int? SpendHours { get; set; }
        public DateTime? LoggedInDttm { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual JiraIssue JiraIssue { get; set; }
    }
}
