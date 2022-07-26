using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;
namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            // Anasayfa daki Tatil & Seyahat Bloğum altında bulunan hareketli resimler 
            var degerler = c.Blogs.OrderByDescending(x=>x.BlogImage).Take(8).ToList(); 
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {   //partial ile son 2 bloğu alıcak partiaal1 ve 2 aynı işemde partial1 içine 2 yi yazdık
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList(); 
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3() //en popüler 10 blog için yaptık
        {
            var deger=c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4() //en begenilen yer kısmı bura  partiaal4 ve 5 aynı işemde partial4 içine 5 yi yazdık
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}