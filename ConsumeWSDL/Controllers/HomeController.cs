using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumeWSDL.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Status()
        {
            //Creating Web Service reference object  
            WSDLServiceReference.WSDLService objPayRef = new WSDLServiceReference.WSDLService();
            List<int> lstIntegers = new List<int> { 5, 6, 7 };

            //calling and storing web service output into the variable  
            var StatusInfo = "Output of WebService: " +objPayRef.Add(lstIntegers.ToArray()).ToString();
            //returning josn result  
            return Json(StatusInfo, JsonRequestBehavior.AllowGet);

        }
    }
}