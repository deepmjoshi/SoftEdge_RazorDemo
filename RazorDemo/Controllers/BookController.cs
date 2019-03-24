using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorDemo.Models;
using RazorDemo.Models.MyDB;

namespace RazorDemo.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            clsBook objBook = new clsBook();
            //{
            //    bookId = 1,
            //    bookName = "Some Book",
            //    Author = "Some Author"
            //};
            //if (!(clsBookTable.lstBook.Any()))
            //    clsBook.AddList(objBook);
            var model = objBook.GetAllBooks();
            return View("Index2", model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(clsBook objBook)
        {
            if (ModelState.IsValid)
            {
                clsBook.AddList(objBook);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int BookId)
        {
            var book = clsBook.GetBookById(BookId);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(clsBook objBook)
        {
            if (ModelState.IsValid)
            {
                var bookToRemove = clsBook.GetBookById(objBook.bookId);
                if (clsBook.RemoveBookById(bookToRemove))
                    clsBook.AddList(objBook);
                return RedirectToAction("Index");
            }
            else
                return View("Index");
        }

        [HttpGet]
        public ActionResult Delete(int bookId)
        {
            var bookToRemove = clsBook.GetBookById(bookId);
            if (clsBook.RemoveBookById(bookToRemove))
            {
                ViewBag.Message = "Book Deleted";
                return RedirectToAction("Index");
            }
            else
                return View("Index");
        }
    }
}