using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Market.Models
{
    [Table("Order")]
  public  class Order
    {
        [Key]
        public int OId { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? ArrDate { get; set; }
        public int iId { get; set; }
        [ForeignKey("iId")]
        public item Item { get; set; }
    }
}
