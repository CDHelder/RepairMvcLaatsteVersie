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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        //public Order Order2 { get; set; }
        public IList<Order> Order { get; set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();

            //Order2 = await _context.Order2.FirstOrDefaultAsync(m => m.OrderId == m.OrderId);
        }
    }
}
