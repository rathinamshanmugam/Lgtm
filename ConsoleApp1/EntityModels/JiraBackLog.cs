using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp1.EntityModels
{
    public partial class JiraBackLog
    {
        public JiraBackLog()
        {
            JiraSprintBacklog = new HashSet<JiraSprintBacklog>();
        }

        public int Id { get; set; }
        public string Summary { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<JiraSprintBacklog> JiraSprintBacklog { get; set; }
    }
}
