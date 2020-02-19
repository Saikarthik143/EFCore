using System;
using System.Collections.Generic;

namespace HandsonREpo.Models
{
    public partial class Project
    {
        public Project()
        {
            Employee = new HashSet<Employee>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
