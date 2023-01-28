using Microsoft.AspNetCore.Mvc;

namespace MathAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("add/{a}/{b}")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
