using System;
using System.Collections.Generic;

namespace EfCoredb1.Models
{
    public partial class Item
    {
        public Item()
        {
            Order = new HashSet<Order>();
        }

        public int IId { get; set; }
        public string ItemName { get; set; }
        public int? Itemprice { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
