using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCVideo.IService;
using MVCVideo.Service;

namespace MVCVideo.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //public HelloWorldController() : this(new HelloService())
        //{
            
        //}

        private IHelloService _helloService;
        //public HelloWorldController(HelloService helloService)
        //{
        //    _helloService = helloService;
        //}

        public String Welcome()
        {
            _helloService = new HelloService();
            return _helloService.GetHelloWorld();
        }
    }
}
