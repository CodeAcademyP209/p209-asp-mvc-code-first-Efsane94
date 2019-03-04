using OnlineBookLibrary.DAL;
using OnlineBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        public HomeController()
        {
            _context = new LibraryContext();
        }
        public ActionResult Index()
        {
            return View(_context.Books);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Details(int id)
        {
            BookDetails selectedBook = new BookDetails()
            {
                id = id,
                book = _context.Books.Where(bookId => bookId.Id == id).First()
            };
            return View(selectedBook);
        }
    }
}