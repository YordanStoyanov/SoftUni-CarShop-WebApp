using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class CarlssuesController : Controller
    {
        public CarlssuesController(Request request) 
            : base(request)
        {
        }

        public Response Carlssues()
        {
            return View();
        }
    }
}
