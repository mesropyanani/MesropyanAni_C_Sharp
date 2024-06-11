using Microsoft.AspNetCore.Mvc;
using WebApplication222.Models;

namespace WebApplication222.Controllers
{
    public class GuestbookController : Controller 
    {

        GuestbookContext _db = new GuestbookContext();
        public ActionResult Index() // *
        {
            var mostRecentEntries = (from entry in _db.Entries
                                     orderby entry.DateAdded descending
                                     select entry).Take(20);
            ViewBag.gg = mostRecentEntries.ToList();
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GuestbookEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            _db.Entries.Add(entry);
            _db.SaveChanges();
            return RedirectToAction("Index"); // *

        }

    }
}
