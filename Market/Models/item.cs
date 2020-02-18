using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Market.Models
{
    [Table("Item")]
    public class item
    {
        [Key]
        
        public int iId{get;set;}
        [Required]
        [StringLength(30)]
        public string ItemName { get; set; }
        public int? Itemprice { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
