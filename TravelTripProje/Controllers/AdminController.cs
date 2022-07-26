using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;
namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b=c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama=b.Aciklama;
            blg.Baslik=b.Baslik;
            blg.BlogImage=b.BlogImage;  
            blg.Tarih=b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDetayGetir(int id)
        {
            var blogdet = c.Blogs.Find(id);
            return View("BlogDetayGetir",blogdet);
        }
        
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr= c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelleme(Yorumlar y)
        {
            var yor = c.Yorumlars.Find(y.ID);
            yor.KullaniciAdi=y.KullaniciAdi;
            yor.Mail=y.Mail;
            yor.Yorum=y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        public ActionResult iletisimListesi()
        {
            var iletisim = c.iletisims.ToList();
            return View(iletisim);
        }
        public ActionResult iletisimSil(int id)
        {
            var b = c.iletisims.Find(id);
            c.iletisims.Remove(b);
            c.SaveChanges();
            return RedirectToAction("iletisimListesi");
        }
        public ActionResult iletisimGetir(int id)
        {
            var ilet = c.iletisims.Find(id);
            return View("iletisimGetir", ilet);
        }
        public ActionResult iletisimGuncelleme(iletisim i)
        {
            var ile = c.iletisims.Find(i.ID);
            ile.AdSoyad = i.AdSoyad;
            ile.Mail = i.Mail;
            ile.Konu = i.Konu;
            ile.Mesaj = i.Mesaj;
            c.SaveChanges();
            return RedirectToAction("iletisimListesi");

        }
        public ActionResult HakkimizdaListesi()
        {
            var hak = c.Hakkimizdas.ToList();
            return View(hak);
        }
        public ActionResult HakkimizdaSil(int id)
        {
            var h = c.Hakkimizdas.Find(id);
            c.Hakkimizdas.Remove(h);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListesi");
        }
        public ActionResult HakkimizdaGetir(int id)
        {
            var hak = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", hak);
        }
        public ActionResult HakkimizdaGüncelleme(Hakkimizda h)
        {
            var ha=c.Hakkimizdas.Find(h.ID);
            ha.FotoUrl = h.FotoUrl;
            ha.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListesi");
        }
    }
}