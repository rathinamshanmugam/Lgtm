using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JenkCommit
    {
        public JenkCommit()
        {
            JenkSourceInfo = new HashSet<JenkSourceInfo>();
        }

        public int Id { get; set; }
        public string CommitId { get; set; }
        public string Comments { get; set; }
        public DateTime? CommitDttm { get; set; }
        public int JenkBuildInfoId { get; set; }
        public int JenkUserId { get; set; }
        public string IsError { get; set; }

        public virtual JenkBuildInfo JenkBuildInfo { get; set; }
        public virtual JenkUser JenkUser { get; set; }
        public virtual ICollection<JenkSourceInfo> JenkSourceInfo { get; set; }
    }
}
