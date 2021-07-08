using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JenkUser
    {
        public JenkUser()
        {
            JenkCommit = new HashSet<JenkCommit>();
        }

        public int Id { get; set; }
        public string Surename { get; set; }
        public string Forename { get; set; }
        public string Email { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int JenkProjectDetailId { get; set; }

        public virtual JenkJobInfo JenkProjectDetail { get; set; }
        public virtual ICollection<JenkCommit> JenkCommit { get; set; }
    }
}
