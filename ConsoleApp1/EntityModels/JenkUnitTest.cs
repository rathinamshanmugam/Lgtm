using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JenkUnitTest
    {
        public int Id { get; set; }
        public int JenkBuildInfoId { get; set; }
        public string Status { get; set; }
        public string Methodname { get; set; }
        public string ErrorDetails { get; set; }
        public string ClassName { get; set; }
        public string ErrorStackTrace { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual JenkBuildInfo JenkBuildInfo { get; set; }
    }
}
