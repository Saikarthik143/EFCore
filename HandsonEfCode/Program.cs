using System;
using HandsonEfCode.Context;
using HandsonEfCode.Model;
using System.Linq;
using System.Collections.Generic;
namespace HandsonEfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                //insert
                //Student s = new Student()
                //{
                //    Sname = "Ajay",
                //    Age = 21,
                //    Std = "Cse"
                //};
                //db.Students.Add(s);
                //db.SaveChanges();
                //fetching the record
                //Student s = db.Students.Find();
                //Console.WriteLine("welcome  {0}", s.Sname);
                //fetching one record by using non priomary key
                //Student s = db.Students.SingleOrDefault(i => i.Age ==21);
                //Console.WriteLine("welcome  {0}", s.Sname);
                //fetching multiple records
                List<Student> list = db.Students.Where(i => i.Age == 21).ToList();
                List<Student> list1 = db.Students.Where(i => i.Age == 21 && i.Std=="Mbbs").ToList();
               
                //update
                Student s2 = db.Students.Find(1);
                s2.Age = 11;//update value
                db.Students.Update(s2);
                db.SaveChanges();

                //delete
                //Student s3 = db.Students.SingleOrDefault(i => i.Sname == "Sarath");
                //db.Students.Remove(s3);
                //db.SaveChanges();
            }
           
        }
    }
}
