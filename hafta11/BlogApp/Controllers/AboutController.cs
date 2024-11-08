using System.ComponentModel;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            About about = new About() {
                FullName = "Rojin Çetiz",
                OnSoz= "Merhabalar , Sizi Kendimi Tanıtmak İstiyorum",
                Alan = "Web Develepor",
                TanıtmaMetni= $"Tekradan merhabalr ben Rojin acun medya akademide back-end developer eğitimi alıyorum",
                tel ="054585465488"

            };
            

            
            return View(about);
        }

    }
}
