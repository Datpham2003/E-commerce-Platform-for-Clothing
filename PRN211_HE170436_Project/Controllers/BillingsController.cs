using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRN211_HE170436_Project.Data;
using PRN211_HE170436_Project.Models;

namespace PRN211_HE170436_Project.Controllers
{
    public class BillingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BillingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Billings
        public async Task<IActionResult> Index()
        {
              return _context.Billing != null ? 
                          View(await _context.Billing.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Billing'  is null.");
        }

        // GET: Billings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Billing == null)
            {
                return NotFound();
            }

            var billing = await _context.Billing
                .FirstOrDefaultAsync(m => m.BillingId == id);
            if (billing == null)
            {
                return NotFound();
            }

            return View(billing);
        }

        // GET: Billings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Billings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BillingFistName,BillingLastName,BillingEmail,BillingPhone,BillingAddress1,BillingAddress2,BillingCountry,BillingCity,BillingState,BillingPostalCode,ProductId")] Billing billing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(billing);
        }

        // GET: Billings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Billing == null)
            {
                return NotFound();
            }

            var billing = await _context.Billing.FindAsync(id);
            if (billing == null)
            {
                return NotFound();
            }
            return View(billing);
        }

        // POST: Billings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BillingId,BillingFistName,BillingLastName,BillingEmail,BillingPhone,BillingAddress1,BillingAddress2,BillingCountry,BillingCity,BillingState,BillingPostalCode,ProductId")] Billing billing)
        {
            if (id != billing.BillingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillingExists(billing.BillingId))
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
            return View(billing);
        }

        // GET: Billings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Billing == null)
            {
                return NotFound();
            }

            var billing = await _context.Billing
                .FirstOrDefaultAsync(m => m.BillingId == id);
            if (billing == null)
            {
                return NotFound();
            }

            return View(billing);
        }

        // POST: Billings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Billing == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Billing'  is null.");
            }
            var billing = await _context.Billing.FindAsync(id);
            if (billing != null)
            {
                _context.Billing.Remove(billing);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillingExists(int id)
        {
          return (_context.Billing?.Any(e => e.BillingId == id)).GetValueOrDefault();
        }
    }
}
