using System.Collections.Generic;
using Apptionary.Models;


namespace Apptionary.Models.ViewModels
{
    public class AppsListViewModel
    {
        public IEnumerable<App> Apps { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
