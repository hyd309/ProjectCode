using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBackend.Api.Dtos;
using CoreBackend.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreBackend.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(ProductService.Current.Products);
        }

        [Route("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = ProductService.Current.Products.SingleOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
