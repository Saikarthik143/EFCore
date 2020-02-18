using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
//poco class plain old clr object
namespace EFClassLib.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [StringLength(5)]
        public string Eid { get; set; }
        [Required]
        [StringLength(30)]
        public string Ename { get; set; }
        [Column(TypeName ="Date")]//to take date instead of date type 
        public DateTime? Joindate { get; set; }
        [StringLength(20)]
        public string Designation { get; set; }
        public decimal? Salary { get; set; }
        public int ProjectId { get; set; }
        //navigation property
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
    }
}
