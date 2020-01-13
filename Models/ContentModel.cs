using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CorporateWebsite.Models
{
    public static class ContentModel
    {
        public static List<ContentModule> GetModules()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<ContentModule> modules = db.ContentModules.Include(x => x.Sections).ToList();
                return modules;
            }
        }

        //public static bool AddModule()
        //{

        //}

        //public static bool AddSection()
        //{

        //}

        public static bool RemoveModule(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.ContentModules.Remove(new ContentModule { Id = id });
                db.SaveChanges();
            }
            return true;
        }

        public static bool RemoveSection(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //db.ModuleSections.Remove(db.ModuleSections.Where(x => x.Id == id).FirstOrDefault());
                db.ModuleSections.Remove(new ModuleSection { Id = id });
                db.SaveChanges();
            }
            return true;
        }
    }
}
