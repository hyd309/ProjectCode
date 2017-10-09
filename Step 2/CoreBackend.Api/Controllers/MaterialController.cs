using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBackend.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CoreBackend.Api.Controllers
{
    [Route("api/product")] // 和主Model的Controller前缀一样
    public class MaterialController : Controller
    {
        [HttpGet("{productId}/materials")]
        public IActionResult GetMaterials(int productId)
        {
            var product = ProductService.Current.Products.SingleOrDefault(x => x.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product.Materials);
        }

        [HttpGet("{productId}/materials/{id}")]
        public IActionResult GetMaterial(int productId, int id)
        {
            var product = ProductService.Current.Products.SingleOrDefault(x => x.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            var material = product.Materials.SingleOrDefault(x => x.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }
    }
}
