using System.Linq;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext context;
        public ValuesController(DataContext context)
        {
            this.context = context;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetValueList()
        {
            return Ok(context.Values.ToList());
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            return Ok(context.Values.FirstOrDefault(value => id == value.Id));
        }
    }
}