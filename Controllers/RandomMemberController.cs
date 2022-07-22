using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomMember.Controllers
{
    public class RandomMemberController : Controller
    {
        // GET: RandomMemberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RandomMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RandomMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RandomMemberController/Create
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

        // GET: RandomMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RandomMemberController/Edit/5
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

        // GET: RandomMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RandomMemberController/Delete/5
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
