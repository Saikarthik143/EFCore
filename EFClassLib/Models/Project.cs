using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFClassLib.Models
{
    [Table("Project")]
   public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [StringLength(30)]
        public string ProjectName { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? Enddate { get; set; }
        //set one to many relatiion
        public IEnumerable<Employee> Employees { get; set; }
    }
}
