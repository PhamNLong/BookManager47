using BookManager47.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager47.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Books.ToList();
            return View(listBook);
        }
        [Authorize]
        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Books.SingleOrDefault(p => p.ID == id);
            if (book == null)
            {
                return HttpNotFound();

            }
            return View(book);
        }
        [Authorize]
        public ActionResult Create(Book book)
        {
            try
            {
                using (BookManagerContext context = new BookManagerContext())
                {
                    context.Books.AddOrUpdate(book);
                    context.SaveChanges();
                }
               // return RedirectToAction("ListBook");
            }
            catch
            {
                
            }
            return View();
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            using (BookManagerContext context = new BookManagerContext())
            {
                return View(context.Books.Where(x => x.ID == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, Book book)
        {
            try
            {

                using (BookManagerContext context = new BookManagerContext())
                {
                  // Book book= context.Books.Where(x => x.ID == id).FirstOrDefault();
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
                // return RedirectToAction("ListBook");
            }
            catch
            {

            }
            return View();
        }
        public ActionResult Details(int id)
        {
            using (BookManagerContext context = new BookManagerContext())
            {
                return View(context.Books.Where(x=>x.ID == id).FirstOrDefault());
            }
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            using (BookManagerContext context = new BookManagerContext())
            {
                return View(context.Books.Where(x => x.ID == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Edit(int id,Book book)
        {
            try
            {
                using (BookManagerContext context = new BookManagerContext())
                {
                    context.Entry(book).State = EntityState.Modified;
                    context.SaveChanges();
                }
                // return RedirectToAction("ListBook");
            }
            catch
            {

            }
            return View();
        }
    }
}