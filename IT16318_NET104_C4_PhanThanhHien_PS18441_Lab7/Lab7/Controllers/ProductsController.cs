using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab7.Models;

namespace Lab7.Controllers
{
    public class ProductsController : Controller
    {
        private readonly slide7Context _context;

        public ProductsController(slide7Context context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(int? id = null)
        {
            var slide7Context = _context.Products.Include(p => p.IdCatNavigation).Where(x=> x.IdCat == id);
            if(id == null)
            {
                slide7Context = _context.Products.Include(p => p.IdCatNavigation);
            }

            return View(await slide7Context.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id , int idcat)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.IdCatNavigation)
                .FirstOrDefaultAsync(m => m.ProductId == id);

            var listne = _context.Products.Where(x=> x.IdCat==idcat);
            ListProductSameCast.RemoveItemsinList(ListProductSameCast.list);
            foreach (var item in listne)
            {
                if(item.ProductId != id)
                ListProductSameCast.list.Add(item);
            };
            
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["IdCat"] = new SelectList(_context.Categories, "IdCat", "NameCat");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Category,Color,UnitPrice,AvailableQuantity,CreateDate,IdCat,Img")] Products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCat"] = new SelectList(_context.Categories, "IdCat", "IdCat", products.IdCat);
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            ViewData["IdCat"] = new SelectList(_context.Categories, "IdCat", "IdCat", products.IdCat);
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ProductId,ProductName,Category,Color,UnitPrice,AvailableQuantity,CreateDate,IdCat,Img")] Products products)
        {
            if (id != products.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.ProductId))
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
            ViewData["IdCat"] = new SelectList(_context.Categories, "IdCat", "IdCat", products.IdCat);
            return View(products);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.IdCatNavigation)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(long id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
