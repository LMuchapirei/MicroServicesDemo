using Microsoft.AspNetCore.Mvc;

namespace CommandService {
    [ApiController]
    [Route("api/c/[controller]")]
    public class PlatformsController: ControllerBase
    {
        public PlatformsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("---> Inbound POST # Command Service");
            return Ok("Inbound Test Okay Platform Controller");
        }    
    }
}