using Microsoft.AspNetCore.Mvc;

namespace RudimentsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RudimentController : ControllerBase
    {
        private static List<Rudiment> rudiments = new List<Rudiment>
            {
                new Rudiment(1, "Single Stroke Roll"),
                new Rudiment(2, "Double Stroke Roll"),
                new Rudiment(3, "Multiple Bounce Roll"),
                new Rudiment(4, "Single Paradiddle"),
                new Rudiment(5, "Double Paradiddle"),
                new Rudiment(6, "Triple Paradiddle"),
                new Rudiment(7, "Single Ratamacue"),
            };
   

        [HttpGet(Name = "GetRudiments")]
        public async Task<ActionResult<List<Rudiment>>> Get()
        {
            
            return Ok(rudiments);
        }
    }
}