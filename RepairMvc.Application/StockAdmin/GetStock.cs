using Microsoft.EntityFrameworkCore;
using RepairMvc.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairMvc.Application.StockAdmin
{
    public class GetStock
    {
        private ApplicationDbContext _ctx;
        public GetStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<ProductViewModel> Do()
        {
            var stock = _ctx.Products
                .Include(x => x.Stock)
                .Select(x => new ProductViewModel
                {
                    ProductId = x.ProductId,
                    Name = x.Name,
                    Stock = x.Stock.Select(y => new StockViewModel
                    {
                        StockId = y.StockId,
                        Description = y.Description,
                        Quantity = y.Quantity
                    })
                })
                .ToList();
                    
            return stock;
        }

        public class StockViewModel
        {
            public int StockId { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
        }

        public class ProductViewModel
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }
    }
}
