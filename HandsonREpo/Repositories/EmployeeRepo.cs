using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonREpo.Models;

namespace HandsonREpo.Repositories
{
    public class EmployeeRepo
    {
        //get all employeess
        public List<Employee> GetAll()
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                return db.Employee.ToList();
            }
        }
        //get emplye by id unique
        public Employee GetById(string id)
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                return db.Employee.Find(id);
            }

        }
        //Add Employee
        public void Add(Employee item)
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        //delete
        public void Delete(string id)
        {
            using (EmsDBContext db = new EmsDBContext())
            {
                Employee e = db.Employee.Find(id);
                    db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        //update the existing record
        public void Update(Employee item)
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }
    }
}
