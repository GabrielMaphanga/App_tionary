using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Apptionary.Models
{
    public class EFAppRepository:IAppsRepository
    {
       
        private ApplicationDbContext context;

        public EFAppRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<App> AppList => context.Apps.ToArray();

        public App GetApp(long key) => context.Apps.First(a => a.AppID == key);      

        

        public void AddApp(App app)
        {
            this.context.Apps.Add(app);
            this.context.SaveChanges();
        }

        public void UpdateApp(App app)
        {
            App a = context.Apps.Find(app.AppID);

            a.Name = app.Name;
            a.Category = app.Category;
            a.Description = app.Description;

            context.SaveChanges();

        }

        public void SaveApp(App app)
        {
            if (app.AppID == 0)
            {
                context.Apps.Add(app);
            }
            else
            {
                App dbEntry = context.Apps
                .FirstOrDefault(a => a.AppID== app.AppID);
                if (dbEntry != null)
                {
                    dbEntry.Name = app.Name;
                    dbEntry.Description = app.Description;                   
                    dbEntry.Category = app.Category;
                }
            }
            context.SaveChanges();
        }
    }
}
