using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Business;

namespace RecipeBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private IService service;

        public DefaultController(IService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> GetAll()
        {
            await service.Do();
            return Ok("Hello");
        }
    }
}