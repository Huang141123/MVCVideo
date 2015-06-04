using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCVideo.IService;

namespace MVCVideo.Service
{
    public class HelloService:IHelloService
    {

        public string GetHelloWorld()
        {
            return "Hello world";
        }
    }
}