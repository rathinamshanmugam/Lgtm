using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class SonarProjectDetail
    {
        public SonarProjectDetail()
        {
            SonarAnalysis = new HashSet<SonarAnalysis>();
            SonarIssue = new HashSet<SonarIssue>();
            SonarStatus = new HashSet<SonarStatus>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<SonarAnalysis> SonarAnalysis { get; set; }
        public virtual ICollection<SonarIssue> SonarIssue { get; set; }
        public virtual ICollection<SonarStatus> SonarStatus { get; set; }
    }
}
