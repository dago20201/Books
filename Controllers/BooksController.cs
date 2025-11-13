using books.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace books.Controllers
{
    public class BooksController : Controller
    {
        Book mybook = new Book(1, "El General y su Laberinto", "Gabriel Garcia Marquez", 1995);
        private static List<Book> bookslist = new List<Book>(); // ✅ static para que se conserve

        public void setbookslist()
        {
            if (bookslist.Count == 0) // ✅ evitar duplicados
            {
                bookslist.Add(mybook);
                bookslist.Add(new Book(10, "Tebas las Cien Puerta", "Desconocido", 2000));
                bookslist.Add(new Book(11, "Nunca pares", "Phil knight", 2010));
            }
        }

        public List<Book> getbooklist()
        {
            return bookslist;
        }

        // GET: BooksController
        public ActionResult Index()
        {
            setbookslist();
            return View(getbooklist());
        }

        public ActionResult Detalle(int id)
        {
            setbookslist();
            mybook = getbooklist().Find(book => book.Id == id);
            return View(mybook);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,titulo,autor,anio")] Book book)
        {
            if (ModelState.IsValid)
            {
                bookslist.Add(book); 
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
