using Microsoft.AspNetCore.Mvc;
using Apptionary.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Apptionary.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        private IAppsRepository appsRepository;


        public AdminController(IAppsRepository repository)
        {
            appsRepository = repository;

        }

        public IActionResult Index() => View(appsRepository.AppList);

        public IActionResult AddApp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddApp(App app)
        {
            appsRepository.AddApp(app);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult UpdateApp(long key)
        {

            return View(appsRepository.GetApp(key));
        }
        [HttpPost]
        public IActionResult UpdateApp(App app)
        {
            appsRepository.UpdateApp(app);
            return RedirectToAction(nameof(Index));
        }

    }
}




     


