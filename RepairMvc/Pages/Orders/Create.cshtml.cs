using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepairMvc.Database;
using RepairMvc.Domain.Models;

namespace RepairMvc.Pages.Orders
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
            /*
            ViewData["ProductID"] = new SelectList(_context.Products, "Id", "Name");
            ViewData["BeginDates"] = new SelectList(_context.Orders, "Id", "BeginDate");
            ViewData["EndDates"] = new SelectList(_context.Orders, "Id", "EndDate");
            ViewData["HoursWorked"] = new SelectList(_context.Orders, "Id", "HoursWorked");
            */

            ViewData["OrderProducts"] = new SelectList(_context.OrderProducts, "ProductId", "OrderId");
            ViewData["Statussen"] = new SelectList(Enum.GetValues<Status>());

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
