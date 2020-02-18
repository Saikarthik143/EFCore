using System;
using Market.Context;
using Market.Models;


namespace MarketSol
{
    class Program
    {
        static void Main(string[] args)
        {
           using(MyContext db=new MyContext())
            {
                item i = new item() { ItemName = "One Plus 7t" };
                Order o = new Order() {  iId=1,OrderDate= Convert.ToDateTime("01.01.1998") };
                db.Add(o);
                db.SaveChanges();
                db.Add(i);
                db.SaveChanges();
            }
        }
    }
}
