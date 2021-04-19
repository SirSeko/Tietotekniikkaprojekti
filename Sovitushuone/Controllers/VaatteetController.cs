using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sovitushuone.Data;
using Sovitushuone.Models;

namespace Sovitushuone.Controllers
{
    public class VaatteetController : Controller
    {
        private readonly SovitushuoneContext _context;
        
        public VaatteetController(SovitushuoneContext context)
        {
            _context = context;
        }

        // GET: Vaatteet
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Vaatteet/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaatteet = await _context.Vaatteet
                .FirstOrDefaultAsync(m => m.id == id);
            if (vaatteet == null)
            {
                return NotFound();
            }

            return View(vaatteet);
        }

        // GET: Vaatteet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaatteet/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nimi,luokka,kuvaus")] Vaatteet vaatteet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaatteet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaatteet);
        }

        // GET: Vaatteet/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaatteet = await _context.Vaatteet.FindAsync(id);
            if (vaatteet == null)
            {
                return NotFound();
            }
            return View(vaatteet);
        }

        // POST: Vaatteet/Edit/5
       

        private bool VaatteetExists(string id)
        {
            return _context.Vaatteet.Any(e => e.id == id);
        }
    }
}
