using RepairMvc.Database;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairMvc.Application.StockAdmin
{
    public class CreateStock
    {
        private ApplicationDbContext _ctx;
        public CreateStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var stock = new Stock
            {
                Description = request.Description,
                Quantity = request.Quantity,
                ProductId = request.ProductId
            };

            _ctx.Stock.Add(stock);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                StockId = stock.StockId,
                Description = stock.Description,
                Quantity = stock.Quantity
            };
        }

        public class Request
        {
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
        }

        public class Response
        {
            public int StockId { get; set; }
            public string Description{ get; set; }
            public int Quantity { get; set; }
        }

    }
}
