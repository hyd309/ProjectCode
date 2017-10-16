using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBackend.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreBackend.Api.Controllers
{
    [Route("api/[controller]")]
    public class TestController: Controller
    {
        private MyContext _context;

        public TestController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
