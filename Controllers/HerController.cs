using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestProjectTZ.Controllers
{
    public class HerController : Controller
    {
        // GET: HerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
