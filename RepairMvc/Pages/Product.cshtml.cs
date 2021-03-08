using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepairMvc.Database;
using RepairMvc.Application.Products;

namespace RepairMvc.Pages
{
    public class ProductModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public ProductModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetProduct.ProductViewModel Product { get; set;}

        public void OnGet(string name)
        {
            Product = new GetProduct(_ctx).Do(name.Replace('_', ' '));
        }
    }
}
