using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Apptionary.Models;
using Apptionary.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace Apptionary.Controllers
{
    public class AppController : Controller
    {

        private IAppsRepository appsRepository;
        public int PageSize = 5;
        public AppController(IAppsRepository repository)
        {
            appsRepository = repository;
        }
        public ViewResult List(string category, string searchString, int appPage = 1)
        {

            var apps = from a in appsRepository.AppList select a;


            if (!String.IsNullOrEmpty(searchString))

            {
                string lower = searchString.ToLower().ToString();
                apps = apps.Where(a => a.Name.Contains(lower)).ToList();

            }

            return View(new AppsListViewModel
            {

                Apps = apps
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.Name)
                    .Skip((appPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = appPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                appsRepository.AppList.Count() :
                appsRepository.AppList.Where(e =>
               e.Category == category).Count()
                },
                CurrentCategory = category

            });


        }
        public PartialViewResult Menu(string category = null,bool horizontalLayout = false)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = appsRepository.AppList
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            string viewName = horizontalLayout ? "MenuHorizontal" : "Default";
            return PartialView(viewName, categories);
        }



    }
}