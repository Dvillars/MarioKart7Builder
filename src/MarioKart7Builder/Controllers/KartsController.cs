using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MarioKart7Builder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarioKart7Builder.ViewModels;

namespace MarioKart7Builder.Controllers
{
    public class KartsController : Controller
    {
        private MarioKart7BuilderContext db = new MarioKart7BuilderContext();
        private readonly UserManager<ApplicationUser> _userManager;

        public IActionResult Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var kartsthing = db.Karts.Include(karts => karts.character).Include(karts => karts.body).Include(karts => karts.glider).Include(karts => karts.tire).Where(karts => karts.userId == userId).ToList();
            return View(kartsthing);
        }

        public IActionResult Details(int id)
        {
            var thisKart = db.Karts.Include(karts => karts.character).Include(karts => karts.body).Include(karts => karts.glider).Include(karts => karts.tire).FirstOrDefault(karts => karts.id == id);
            return View(thisKart);
        }

        public IActionResult Create()
        {
            CreateKartViewModel vm = new CreateKartViewModel();

            List<Character> AllCharacters = db.Characters.ToList();
            IEnumerable<SelectListItem> CharacterSelectList = 
                from c in AllCharacters
                select new SelectListItem
                    {
                        Value = c.id.ToString(),
                        Text = c.name
                    };
            vm.Characters = CharacterSelectList;

            List<Body> AllBodys = db.Bodys.ToList();
            IEnumerable<SelectListItem> BodySelectList =
                from c in AllBodys
                select new SelectListItem
                {
                    Value = c.id.ToString(),
                    Text = c.name
                };
            vm.Bodys = BodySelectList;

            List<Tire> AllTires = db.Tires.ToList();
            IEnumerable<SelectListItem> TireSelectList =
                from c in AllTires
                select new SelectListItem
                {
                    Value = c.id.ToString(),
                    Text = c.name
                };
            vm.Tires = TireSelectList;

            List<Character> AllCharacters = db.Characters.ToList();
            IEnumerable<SelectListItem> CharacterSelectList =
                from c in AllCharacters
                select new SelectListItem
                {
                    Value = c.id.ToString(),
                    Text = c.name
                };
            vm.Characters = CharacterSelectList;
            vm.kart = new Kart();

            //ViewBag.CharactersId = new SelectList(db.Characters, "CharactersId", "Name");
            //ViewBag.BodysId = new SelectList(db.Bodys, "BodysId", "Name");
            //ViewBag.TiresId = new SelectList(db.Tires, "TiresId", "Name");
            //ViewBag.GlidersId = new SelectList(db.Gliders, "GlidersId", "Name");
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(CreateKartViewModel vm)
        {
            Kart newkart = vm.kart;
            newkart.userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            db.Karts.Add(newkart);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult Create(string newName, int newCharacterId, int newbodyId, int newTireId, int newGliderId)
        //{
        //    Kart newkart = new Kart();
        //    newkart.name = newName;
        //    newkart.userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //    newkart.character = db.Characters.FirstOrDefault(karts => karts.id == newCharacterId);
        //    newkart.body = db.Bodys.FirstOrDefault(karts => karts.id == newbodyId);
        //    newkart.tire = db.Tires.FirstOrDefault(karts => karts.id == newTireId);
        //    newkart.glider = db.Gliders.FirstOrDefault(karts => karts.id == newGliderId);
        //    db.Karts.Add(newkart);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");

        //}

        public IActionResult Edit(int id)
        {
            var thisKart = db.Karts.FirstOrDefault(karts => karts.id == id);
            return View(thisKart);
        }

        [HttpPost]
        public IActionResult Edit(Kart kart)
        {
            db.Entry(kart).State = EntityState.Modified;
            kart.userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
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
