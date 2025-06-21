using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Static;

namespace WebApp.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
  
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string GetUserName() 
        {
            return RunTimeData.userData.Name;
        }
    }
}
