using RepairMvc.Database;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairMvc.Application.StockAdmin
{
    public class DeleteStock
    {
        private ApplicationDbContext _ctx;

        public DeleteStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var stock = _ctx.Stock.FirstOrDefault();

            _ctx.Stock.Remove(stock);

            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
