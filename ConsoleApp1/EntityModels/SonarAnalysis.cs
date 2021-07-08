using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class SonarAnalysis
    {
        public int Id { get; set; }
        public int SonarProjectDetailId { get; set; }
        public string OrganizationName { get; set; }
        public string Key { get; set; }
        public DateTime? LastAnalysisDttm { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual SonarProjectDetail SonarProjectDetail { get; set; }
    }
}
