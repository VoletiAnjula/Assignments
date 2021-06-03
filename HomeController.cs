using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using custordempdetassign.Models;
using Newtonsoft.Json;

namespace custordempdetassign.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            IEnumerable<fulldata> emp = null;
            using(WebClient webClient=new WebClient())
            {
                webClient.BaseAddress = "https://localhost:44340/api/";
                var json = webClient.DownloadString("Values/" + 10248);
                var list = JsonConvert.DeserializeObject<List<fulldata>>(json);
                emp = list.ToList();

            }

            return View(emp);
        }
    }
}
