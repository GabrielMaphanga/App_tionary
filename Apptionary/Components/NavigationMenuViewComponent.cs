using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Apptionary.Models;
using System.Collections.Generic;

namespace Apptionary.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {

        private IAppsRepository repository;

        public NavigationMenuViewComponent(IAppsRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke(string category = null, bool horizontalLayout = false)
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            string viewName = horizontalLayout ? "MenuHorizontal" : "Default";
            IEnumerable<string> categories = repository.AppList
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);


            return View(viewName, categories);
        }
    }
}
