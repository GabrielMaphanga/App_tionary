using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apptionary.Models
{
    public interface IAppsRepository
    {
       
        IEnumerable<App> AppList { get;  }

        App GetApp(long key);

        void AddApp(App app);

        void UpdateApp(App app);

        void SaveApp(App app);

       
    }
}
