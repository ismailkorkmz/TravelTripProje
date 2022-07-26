using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();

        public ActionResult Index(iletisim il)
        {
            c.iletisims.Add(il);
            c.SaveChanges();
            //var deger = c.iletisims.ToList();
            return View("Index");
        }
        
    }
}