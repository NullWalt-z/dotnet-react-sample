using Microsoft.AspNetCore.Mvc;

namespace TodoMvc.About
{
    [Route("/api/[controller]")]
    public class AboutController : Controller
    {
        [HttpGet]
        public IActionResult GetAbout() {
            return Ok(new {
                version = "0.1.0"
            });
        }
    }
}