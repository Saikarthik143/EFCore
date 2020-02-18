using System;
using EFClassLib;
using EFClassLib.Models;
using EFClassLib.Context;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ProjectContext db=new ProjectContext())
            {
                Project p = new Project() { ProjectName = ".Net" };
                db.Add(p);
                db.SaveChanges();

            }
          
        }
    }
}
