using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyFirstDotNetCoreApplication.Models;
using MyFirstDotNetCoreApplication.Services;

namespace MyFirstDotNetCoreApplication.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ILogger<ProductsModel> _logger;
        public JsonFileProductService jsonFileProductService;
        public IEnumerable<Product> Products { get; private set; }
        public ProductsModel(ILogger<ProductsModel> logger,JsonFileProductService productService)
        {
            _logger = logger;
            jsonFileProductService = productService;

        }


        public void OnGet()
        {
            Products = jsonFileProductService.GetProducts();
        }
    }
}