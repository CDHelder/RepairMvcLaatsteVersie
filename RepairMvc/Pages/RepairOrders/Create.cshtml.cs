using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepairMvc.Database;
using RepairMvc.Domain.Models;

namespace Razor_Identity.Pages.RepairOrders
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            ViewData["PartID"] = new SelectList(_context.Products, "ProductId", "Name");
            ViewData["Statussen"] = new SelectList(Enum.GetValues<Status>());
            ViewData["BeginDates"] = new SelectList(_context.Orders, "OrderId", "BeginDate");
            ViewData["EndDates"] = new SelectList(_context.Orders, "OrderId", "EndDate");
            ViewData["HoursWorked"] = new SelectList(_context.Orders, "OrderId", "HoursWorked");

            return Page();
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
