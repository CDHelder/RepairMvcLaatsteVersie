using RepairMvc.Database;
using RepairMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairMvc.Application.ProductsAdmin
{
    public class UpdateProduct
    {
        private ApplicationDbContext _context;

        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductId == request.ProductId);

            product.Name = request.Name;
            product.PartType = request.PartType;
            product.Description = request.Description;
            product.Price = request.Price;

            await _context.SaveChangesAsync();

            return new Response
            {
                ProductId = product.ProductId,
                Name = product.Name,
                PartType = product.PartType,
                Description = product.Description,
                Price = product.Price
            };
        }

        public class Request
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public PartType PartType { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }

        public class Response
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public PartType PartType { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}
