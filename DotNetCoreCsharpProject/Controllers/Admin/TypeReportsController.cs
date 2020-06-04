using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreCsharpProject.Entities;
using Microsoft.AspNetCore.Authorization;

namespace DotNetCoreCsharpProject.Controllers.Admin
{
    [Authorize(Roles = "ADMIN")]
    public class TypeReportsController : Controller
    {
        private readonly DataContext _context;

        public TypeReportsController(DataContext context)
        {
            _context = context;
        }

        // GET: TypeReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeReports.ToListAsync());
        }

        // GET: TypeReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeReports = await _context.TypeReports
                .FirstOrDefaultAsync(m => m.IdType == id);
            if (typeReports == null)
            {
                return NotFound();
            }

            return View(typeReports);
        }

        // GET: TypeReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdType,Type")] TypeReports typeReports)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeReports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeReports);
        }

        // GET: TypeReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeReports = await _context.TypeReports.FindAsync(id);
            if (typeReports == null)
            {
                return NotFound();
            }
            return View(typeReports);
        }

        // POST: TypeReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdType,Type")] TypeReports typeReports)
        {
            if (id != typeReports.IdType)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeReports);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeReportsExists(typeReports.IdType))
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
            return View(typeReports);
        }

        // GET: TypeReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeReports = await _context.TypeReports
                .FirstOrDefaultAsync(m => m.IdType == id);
            if (typeReports == null)
            {
                return NotFound();
            }

            return View(typeReports);
        }

        // POST: TypeReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeReports = await _context.TypeReports.FindAsync(id);
            _context.TypeReports.Remove(typeReports);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeReportsExists(int id)
        {
            return _context.TypeReports.Any(e => e.IdType == id);
        }
    }
}
