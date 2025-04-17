using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace xunitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //    public string Index()
        //    {
        //        return "Hello, World!";
        //    }
        //}
        public string Index(int number)
        {
            if (number < 0)
            {
                return "Negative number";
            }
            else if (number == 0)
            {
                return "Zero";
            }
            else
            {
                return "Positive number";
            }
        }
    }
}
