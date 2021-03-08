using Microsoft.EntityFrameworkCore;
using RepairMvc.Database;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepairMvc.Application.Products
{
    public class GetProduct
    {
        private ApplicationDbContext _ctx;
        public GetProduct(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductViewModel Do(string name) =>
            _ctx.Products
            .Include(x => x.Stock)
            .Where(x => x.Name == name).Select(x => new ProductViewModel
            {
                ProductId = x.ProductId,
                Name = x.Name,
                PartType = x.PartType,
                Description = x.Description,
                Price = x.Price,

                Stock = x.Stock.Select(y => new StockViewModel
                {
                    StockId = y.StockId,
                    Description = y.Description,
                    InStock = y.Quantity > 0
                })
            }).FirstOrDefault();

        public class ProductViewModel
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public PartType PartType { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public IEnumerable<StockViewModel>Stock { get; set; }

        }

        public class StockViewModel
        {
            public int StockId { get; set; }
            public string Description { get; set; }
            public bool InStock { get; set; }
        }
    }
}
