using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarioKart7Builder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MarioKart7Builder.Controllers
{
    public class KartsController : Controller
    {
        private MarioKart7BuilderContext db = new MarioKart7BuilderContext();
        private readonly UserManager<ApplicationUser> _userManager;

        public IActionResult Index()
        {
            var nowuser = !!!;
            var allKarts = db.Karts.Where(karts => karts.userId == nowuser).ToList();
            return View(allKarts);
        }

        public IActionResult Details(int id)
        {
            var thisKart = db.Karts.FirstOrDefault(karts => karts.id == id);
            return View(thisKart);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kart newkart)
        {
            db.Karts.Add(newkart);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisKart = db.Karts.FirstOrDefault(karts => karts.id == id);
            return View(thisKart);
        }

        [HttpPost]
        public IActionResult Edit(Kart kart)
        {
            db.Entry(kart).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisKart = db.Karts.FirstOrDefault(karts => karts.id == id);
            return View(thisKart);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisKart = db.Karts.FirstOrDefault(karts => karts.id == id);
            db.Karts.Remove(thisKart);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
