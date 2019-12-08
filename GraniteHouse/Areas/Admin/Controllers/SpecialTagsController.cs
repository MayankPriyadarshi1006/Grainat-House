using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraniteHouse.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialTagsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SpecialTagsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.SpecialTags.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTag specialtags)
        {
            if (ModelState.IsValid)
            {
                _db.Add(specialtags);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(specialtags);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialtag = await _db.SpecialTags.FindAsync(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            return View(specialtag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SpecialTag specialtag)
        {
            if (id != specialtag.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(specialtag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialtag);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialtag = await _db.SpecialTags.FindAsync(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            return View(specialtag);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialtag = await _db.SpecialTags.FindAsync(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            return View(specialtag);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            var specialtag = await _db.SpecialTags.FindAsync(id);

            _db.SpecialTags.Remove(specialtag);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}