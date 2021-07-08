using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JenkBuildInfo
    {
        public JenkBuildInfo()
        {
            JenkCommit = new HashSet<JenkCommit>();
            JenkLogDetail = new HashSet<JenkLogDetail>();
            JenkUnitTest = new HashSet<JenkUnitTest>();
        }

        public int Id { get; set; }
        public int? BuildNo { get; set; }
        public string Status { get; set; }
        public DateTime? BuildDttm { get; set; }
        public int JenkJobInfoId { get; set; }
        public string ConsoleTextUrl { get; set; }
        public int? Duration { get; set; }
        public int? EstimatedDuration { get; set; }

        public virtual JenkJobInfo JenkJobInfo { get; set; }
        public virtual ICollection<JenkCommit> JenkCommit { get; set; }
        public virtual ICollection<JenkLogDetail> JenkLogDetail { get; set; }
        public virtual ICollection<JenkUnitTest> JenkUnitTest { get; set; }
    }
}
