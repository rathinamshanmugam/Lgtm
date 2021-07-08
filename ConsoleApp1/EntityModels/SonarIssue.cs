using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class SonarIssue
    {
        public int Id { get; set; }
        public int SonarProjectDetailId { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
        public string Severity { get; set; }
        public string Message { get; set; }
        public string Line { get; set; }
        public string RuleName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual SonarProjectDetail SonarProjectDetail { get; set; }
    }
}
