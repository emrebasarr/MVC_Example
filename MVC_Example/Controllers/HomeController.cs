using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;
using MVC_Example.Models;

namespace MVC_Example.Controllers
{
    public class HomeController : Controller
    {
        public static List<ComicBooks> books = new List<ComicBooks>();
        public static List<Mangas> mangas = new List<Mangas>()
        {
            new Mangas() {Id=1,Name="One Punch Man",NumberPrints="123",PublicationLanguage="Türkçe",Writer="yozuko"}
        };

        // Ana Sayfa
        
        public IActionResult Index()
        {
            return View();
        }

        //Comic Book

        public IActionResult ComicBook()
        {
            return View(books);
        }

        //Comic Book Create

        public IActionResult CreateC()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateC(ComicBooks book)
        {
            books.Add(book);
            return View();
        }

        //Mangas

        public IActionResult Manga()
        {
            return View(mangas);
        }

        //Manga Create

        public IActionResult CreateM()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateM(Mangas mnga)
        {
           mangas.Add(mnga);
           return View();
        }
    }
}