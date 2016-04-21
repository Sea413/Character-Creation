using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CharacterCreator.Models;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CharacterCreator.Controllers
{
    public class CharactersController : Controller
    {
        private CharacterCreatorContext db = new CharacterCreatorContext();

        public IActionResult Index()
        {
            return View(db.Characters.Include(characters => characters.Hair).Include(characters => characters.Skin).Include(characters => characters.Personality).Include(characters => characters.Outfit).ToList());
        }
        public ActionResult Create()
        {
            ViewBag.personalityId = new SelectList(db.Personalities, "personalityId", "name");
            ViewBag.hairId = new SelectList(db.Hairs, "hairId", "name");
            ViewBag.skinId = new SelectList(db.Skins, "skinId", "name");
            ViewBag.outfitId = new SelectList(db.Outfits, "outfitId", "name");


            return View();
        }

        [HttpPost]
        public ActionResult Create(Character character)
        {
            db.Characters.Add(character);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var thisCharacter = db.Characters.Include(characters => characters.Hair).Include(characters => characters.Skin).Include(characters => characters.Personality).Include(characters => characters.Outfit).FirstOrDefault(characters => characters.id == id);
            return View(thisCharacter);
        }

        public ActionResult Edit(int id)
        {
            var thisCharacter = db.Characters.FirstOrDefault(characters => characters.id == id);
            ViewBag.personalityId = new SelectList(db.Personalities, "personalityId", "name");
            ViewBag.hairId = new SelectList(db.Hairs, "hairId", "name");
            ViewBag.skinId = new SelectList(db.Skins, "skinId", "name");
            ViewBag.outfitId = new SelectList(db.Outfits, "outfitId", "name");
            return View(thisCharacter);
        }
        [HttpPost]
        public ActionResult Edit(Character character)
        {
            db.Entry(character).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var thischaracter = db.Characters.FirstOrDefault(x => x.id == id);
            db.Characters.Remove(thischaracter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
