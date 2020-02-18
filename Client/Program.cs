using System;
using EfCoredb1.Models;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
           using(EmsDBContext db=new EmsDBContext())
            {
                Product p = new Product() {  Pname = "ONe Plus 7T pro", Price = 50000 };
                db.Add(p);
                db.SaveChanges();
                Item i = new Item() { ItemName = "Hp", Itemprice=45000 };
                db.Add(i);
                db.SaveChanges();
            }
        }
    }
}
