using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeSimpleCRUD.Data;
using CodeSimpleCRUD.Models;

namespace CodeSimpleCRUD.Controllers
{
    public class Product_AjaxController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Product_AjaxController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Product_Ajax
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product_Ajaxes.ToListAsync());
        }

        // GET: Product_Ajax/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Ajax = await _context.Product_Ajaxes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Ajax == null)
            {
                return NotFound();
            }

            return View(product_Ajax);
        }

        // GET: Product_Ajax/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product_Ajax/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name,Descrption,Category,Cost,Pric")] Product_Ajax product_Ajax)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Ajax);
                await _context.SaveChangesAsync();
                TempData["AlertMessage"] = "Product Created Successfully...!";
                return RedirectToAction(nameof(Index));
            }
            return View(product_Ajax);
        }

        // GET: Product_Ajax/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Ajax = await _context.Product_Ajaxes.FindAsync(id);
            if (product_Ajax == null)
            {
                return NotFound();
            }
            return View(product_Ajax);
        }

        // POST: Product_Ajax/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name,Descrption,Category,Cost,Pric")] Product_Ajax product_Ajax)
        {
            if (id != product_Ajax.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Ajax);
                    await _context.SaveChangesAsync();
                    TempData["AlertMessage"] = "Product Updated Successfully...!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_AjaxExists(product_Ajax.Id))
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
            return View(product_Ajax);
        }

        // GET: Product_Ajax/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Ajax = await _context.Product_Ajaxes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Ajax == null)
            {
                return NotFound();
            }

            return View(product_Ajax);
        }

        // POST: Product_Ajax/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product_Ajax = await _context.Product_Ajaxes.FindAsync(id);
            _context.Product_Ajaxes.Remove(product_Ajax);
            await _context.SaveChangesAsync();
            TempData["AlertMessage"] = "Product Deleted Successfully...!";
            return RedirectToAction(nameof(Index));
        }

        private bool Product_AjaxExists(int id)
        {
            return _context.Product_Ajaxes.Any(e => e.Id == id);
        }
    }
}
