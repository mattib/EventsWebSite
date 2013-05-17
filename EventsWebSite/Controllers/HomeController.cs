using EventsWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsWebSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var eventsModel = new EventsModel();
            eventsModel.Events = new Event[2];
            for(var i = 0; i < 2; i++)
            {
                eventsModel.Events[i] = new Event();
                eventsModel.Events[i].Text = "This is a test " + i;
                eventsModel.Events[i].Id = i;
                eventsModel.Events[i].InputType = 4;
            }
            return View(eventsModel);
        }

    }
}
