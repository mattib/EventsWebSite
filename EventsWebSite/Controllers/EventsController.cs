using EventsWebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EventsWebSite.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/

        public ActionResult Index()
        {
            var result = string.Empty;
            using (var client = new WebClient())
            {
                var data = client.OpenRead("http://eventapi.apphb.com/api/event");
                var reader = new StreamReader(data);
                result = reader.ReadToEnd();
            }

            List<Event> events = (List<Event>)Newtonsoft.Json.JsonConvert.DeserializeObject(result, typeof(List<Event>));


            var eventsModel = new EventsModel();
            eventsModel.Events = events.ToArray();
            return View(eventsModel);
        }

    }
}
