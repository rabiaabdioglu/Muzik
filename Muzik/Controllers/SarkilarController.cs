using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Muzik.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Muzik.Controllers
{
    public class SarkilarController : Controller
    {
        private readonly MuzikDataContext _context;


        public  SarkilarController(MuzikDataContext _wcontext)
        {
            _context = _wcontext;
        }
     


        public IActionResult Getir()
        {
            return View();
        }
        public IActionResult Index()
        {
           
                return View();
            
        }
        public IActionResult Create([Bind("SarkiId,SarkiAd,AlbumAd,CikisYili,Artist,Tur,SarkiSuresi")] Sarkilar sarkilar)
        {

            _context.Add(sarkilar);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sarki_detay = await _context.Muzik
                .FirstOrDefaultAsync(m => m.SarkiId == id);
            if (sarki_detay == null)
            {
                return NotFound();
            }

            return View(sarki_detay);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sarkilar = await _context.Muzik.FindAsync(id);
            if (sarkilar == null)
            {
                return NotFound();
            }

            return View("Edit", sarkilar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SarkiId,SarkiAd,AlbumAd,CikisYili,Artist,Tur,SarkiSuresi")] Sarkilar sarkilar)
        {
            /*
             * This not required, request created for id, this guaranteed by anti forgery token
             * Also, You should be redirect if the situation requires cancel the action.
            if (id != sarkilar.SarkiId)
            {
                return NotFound();
            }
            */
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sarkilar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SarkiExists(sarkilar.SarkiId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sarkilar);
        }

        // GET: Authors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sarkilar = await _context.Muzik
                .FirstOrDefaultAsync(m => m.SarkiId == id);
            if (sarkilar == null)
            {
                return NotFound();
            }

            return View(sarkilar);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bulunan = await _context.Muzik.FindAsync(id);
            _context.Muzik.Remove(bulunan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool SarkiExists(int id)
        {
            return _context.Muzik.Any(e => e.SarkiId == id);
        }
    }
}
