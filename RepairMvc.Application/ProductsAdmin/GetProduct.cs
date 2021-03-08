using RepairMvc.Database;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairMvc.Application.ProductsAdmin
{
    public class GetProduct
    {
        private ApplicationDbContext _ctx;
        public GetProduct(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductViewModel Do(int id) =>
            _ctx.Products.Where(x => x.ProductId == id).Select(x => new ProductViewModel
            {
                ProductId = x.ProductId,
                Name = x.Name,
                PartType = x.PartType,
                Description = x.Description,
                Price = x.Price,
            }).FirstOrDefault();

        public class ProductViewModel
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public PartType PartType { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}