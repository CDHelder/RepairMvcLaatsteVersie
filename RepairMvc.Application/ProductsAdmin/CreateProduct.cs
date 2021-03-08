using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RepairMvc.Database;
using RepairMvc.Domain.Models;

namespace RepairMvc.Application.ProductsAdmin
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> Do(Request request)
        {
            var product = new Product
            {
                Name = request.Name,
                PartType = request.PartType,
                Description = request.Description,
                Price = request.Price
            };

            _context.Products.Add(product);

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