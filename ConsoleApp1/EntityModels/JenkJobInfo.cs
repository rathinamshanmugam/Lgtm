using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JenkJobInfo
    {
        public JenkJobInfo()
        {
            JenkBuildInfo = new HashSet<JenkBuildInfo>();
            JenkUser = new HashSet<JenkUser>();
        }

        public int Id { get; set; }
        public string JobName { get; set; }
        public string Url { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int JenkProjectDetailId { get; set; }

        public virtual JenkProjectDetail JenkProjectDetail { get; set; }
        public virtual ICollection<JenkBuildInfo> JenkBuildInfo { get; set; }
        public virtual ICollection<JenkUser> JenkUser { get; set; }
    }
}
