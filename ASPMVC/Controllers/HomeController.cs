using ASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {

           
            return View();
        }
        [HttpPost]
        public ActionResult Index(Devices dvc)
        {

            
            return View(dvc);
        }
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
           
            
            RedirectToAction("Index",new { Button = System.Text.Encoding.UTF8.GetString(e.Message) });
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}