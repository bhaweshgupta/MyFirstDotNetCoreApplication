using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDotNetCoreApplication.Models;
using MyFirstDotNetCoreApplication.Services;

namespace MyFirstDotNetCoreApplication.Controllers
{
    [Route("con")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public JsonFileProductService ProductService { get; }


        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();

        }
      

        public class RatingRequest
        {
            public string ProductId { get; set; }
            public int Rating { get; set; }
        }









    }
}
