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
            ViewBag.landSpeed = thisKart.character.landSpeed + thisKart.glider.landSpeed + thisKart.body.landSpeed + thisKart.tire.landSpeed;
            ViewBag.waterSpeed = thisKart.character.waterSpeed + thisKart.glider.waterSpeed + thisKart.body.waterSpeed + thisKart.tire.waterSpeed;
            ViewBag.airSpeed = thisKart.character.airSpeed + thisKart.glider.airSpeed + thisKart.body.airSpeed + thisKart.tire.airSpeed;
            ViewBag.acceleration = thisKart.character.acceleration + thisKart.glider.acceleration + thisKart.body.acceleration + thisKart.tire.acceleration;
            ViewBag.weight = thisKart.character.weight + thisKart.glider.weight + thisKart.body.weight + thisKart.tire.weight;
            ViewBag.landHandling = thisKart.character.landHandling + thisKart.glider.landHandling + thisKart.body.landHandling + thisKart.tire.landHandling;
            ViewBag.watrHandling = thisKart.character.watrHandling + thisKart.glider.watrHandling + thisKart.body.watrHandling + thisKart.tire.watrHandling;
            ViewBag.airHandling = thisKart.character.airHandling + thisKart.glider.airHandling + thisKart.body.airHandling + thisKart.tire.airHandling;
            ViewBag.stabiliy = thisKart.character.stabiliy + thisKart.glider.stabiliy + thisKart.body.stabiliy + thisKart.tire.stabiliy;
            ViewBag.drift = thisKart.character.drift + thisKart.glider.drift + thisKart.body.drift + thisKart.tire.drift;
            ViewBag.miniTurbo = thisKart.character.miniTurbo + thisKart.glider.miniTurbo + thisKart.body.miniTurbo + thisKart.tire.miniTurbo;
            ViewBag.offRoad = thisKart.character.offRoad + thisKart.glider.offRoad + thisKart.body.offRoad + thisKart.tire.offRoad;
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

            List<Glider> AllGliders = db.Gliders.ToList();
            IEnumerable<SelectListItem> GliderSelectList =
                from c in AllGliders
                select new SelectListItem
                {
                    Value = c.id.ToString(),
                    Text = c.name
                };
            vm.Gliders = GliderSelectList;
            vm.kart = new Kart();

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

        public IActionResult Edit(int id)
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

            List<Glider> AllGliders = db.Gliders.ToList();
            IEnumerable<SelectListItem> GliderSelectList =
                from c in AllGliders
                select new SelectListItem
                {
                    Value = c.id.ToString(),
                    Text = c.name
                };
            vm.Gliders = GliderSelectList;
            vm.kart = db.Karts.FirstOrDefault(karts => karts.id == id);
            return View(vm);
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
