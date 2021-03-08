using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepairMvc.Database;
using RepairMvc.Domain.Models;

namespace RepairMvc.Pages.Orders
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Orders.FirstOrDefaultAsync(m => m.OrderId == id);


            if (Order == null)
            {
                return NotFound();
            }

            ViewData["Statussen"] = new SelectList(Enum.GetValues<Status>());

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order.OrderId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //~~~~~~~~ Get value van naam ~~~~~~~~
            if (Order.PartID1 != null)
            {
                var RepairOrderPartID1 = Order.PartID1;
                var PartID1 = (from p in _context.Products where p.ProductId == RepairOrderPartID1 select p.Name).ToList();
                var PartID1Price = (from p in _context.Products where p.ProductId == RepairOrderPartID1 select p.Price).ToList();
                foreach (string str in PartID1)
                {
                    ViewData["PartID1"] = str;
                }
                foreach (var str in PartID1Price)
                {
                    ViewData["PartID1Price"] = str;
                }
            }
            if (Order.PartID2 != null)
            {
                var RepairOrderPartID2 = Order.PartID2;
                var PartID2 = (from p in _context.Products where p.ProductId == RepairOrderPartID2 select p.Name).ToList();
                var PartID2Price = (from p in _context.Products where p.ProductId == RepairOrderPartID2 select p.Price).ToList();
                foreach (string str in PartID2)
                {
                    ViewData["PartID2"] = str;
                }
                foreach (var str in PartID2Price)
                {
                    ViewData["PartID2Price"] = str;
                }
            }
            if (Order.PartID3 != null)
            {
                var RepairOrderPartID3 = Order.PartID3;
                var PartID3 = (from p in _context.Products where p.ProductId == RepairOrderPartID3 select p.Name).ToList();
                var PartID3Price = (from p in _context.Products where p.ProductId == RepairOrderPartID3 select p.Price).ToList();
                foreach (string str in PartID3)
                {
                    ViewData["PartID3"] = str;
                }
                foreach (var str in PartID3Price)
                {
                    ViewData["PartID3Price"] = str;
                }
            }
            if (Order.PartID4 != null)
            {
                var RepairOrderPartID4 = Order.PartID4;
                var PartID4 = (from p in _context.Products where p.ProductId == RepairOrderPartID4 select p.Name).ToList();
                var PartID4Price = (from p in _context.Products where p.ProductId == RepairOrderPartID4 select p.Price).ToList();
                foreach (string str in PartID4)
                {
                    ViewData["PartID4"] = str;
                }
                foreach (var str in PartID4Price)
                {
                    ViewData["PartID4Price"] = str;
                }
            }
            if (Order.PartID5 != null)
            {
                var RepairOrderPartID5 = Order.PartID5;
                var PartID5 = (from p in _context.Products where p.ProductId == RepairOrderPartID5 select p.Name).ToList();
                var PartID5Price = (from p in _context.Products where p.ProductId == RepairOrderPartID5 select p.Price).ToList();
                foreach (string str in PartID5)
                {
                    ViewData["PartID5"] = str;
                }
                foreach (var str in PartID5Price)
                {
                    ViewData["PartID5Price"] = str;
                }
            }
            if (Order.PartID6 != null)
            {
                var RepairOrderPartID6 = Order.PartID6;
                var PartID6 = (from p in _context.Products where p.ProductId == RepairOrderPartID6 select p.Name).ToList();
                var PartID6Price = (from p in _context.Products where p.ProductId == RepairOrderPartID6 select p.Price).ToList();
                foreach (string str in PartID6)
                {
                    ViewData["PartID6"] = str;
                }
                foreach (var str in PartID6Price)
                {
                    ViewData["PartID6Price"] = str;
                }
            }
            if (Order.PartID7 != null)
            {
                var RepairOrderPartID7 = Order.PartID7;
                var PartID7 = (from p in _context.Products where p.ProductId == RepairOrderPartID7 select p.Name).ToList();
                var PartID7Price = (from p in _context.Products where p.ProductId == RepairOrderPartID7 select p.Price).ToList();
                foreach (string str in PartID7)
                {
                    ViewData["PartID7"] = str;
                }
                foreach (var str in PartID7Price)
                {
                    ViewData["PartID7Price"] = str;
                }
            }
            if (Order.PartID8 != null)
            {
                var RepairOrderPartID8 = Order.PartID8;
                var PartID8 = (from p in _context.Products where p.ProductId == RepairOrderPartID8 select p.Name).ToList();
                var PartID8Price = (from p in _context.Products where p.ProductId == RepairOrderPartID8 select p.Price).ToList();
                foreach (string str in PartID8)
                {
                    ViewData["PartID8"] = str;
                }
                foreach (var str in PartID8Price)
                {
                    ViewData["PartID8Price"] = str;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
