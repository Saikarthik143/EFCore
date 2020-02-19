using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonREpo.Models;

namespace HandsonREpo.Repositories
{
    public class ProjectRepo
    {
        //getting all details
        public List<Project> GetAll()
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                return db.Project.ToList();
            }
        }
        //getting particular id
        public Project Get(int id)
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                return db.Project.Find(id);
            }
        }

        public void Add(Project item)
        {
            using(EmsDBContext db=new EmsDBContext())
            {
                db.Project.Add(item);
                db.SaveChanges();
            }
        }
        public void Update(Project item)
        {
            using (EmsDBContext db = new EmsDBContext())
            {
                db.Project.Update(item);
                db.SaveChanges();
            }
        }
             public void Delete(int id)
        {
            using (EmsDBContext db = new EmsDBContext())
            {
                Project p = db.Project.Find(id);
                db.Project.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
