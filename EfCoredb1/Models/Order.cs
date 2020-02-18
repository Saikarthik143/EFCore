using System;
using System.Collections.Generic;

namespace EfCoredb1.Models
{
    public partial class Order
    {
        public int Oid { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ArrDate { get; set; }
        public int IId { get; set; }

        public virtual Item I { get; set; }
    }
}
