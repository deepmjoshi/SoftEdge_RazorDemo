using RazorDemo.Models.MyDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RazorDemo.Models
{
    public class clsBook
    {
        [Required]
            [Display(Name ="Id")]
        public int bookId
        { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string bookName
        { get; set; }

        [Display(Name ="Author")]
        public string Author
        { get; set; }

        public static List<clsBook> AddList(clsBook objBook)
        {
            int maxId = clsBook.GetMaxId();
            objBook.bookId = maxId;
            clsBookTable.lstBook.Add(objBook);
            return clsBookTable.lstBook;
        }

        private static int GetMaxId()
        {
            if (clsBookTable.lstBook != null && clsBookTable.lstBook.Any())
                return clsBookTable.lstBook.Select(x => x.bookId).Max() + 1;
            else
                return 1;
        }

        public List<clsBook> GetAllBooks()
        {
            return clsBookTable.lstBook;
        }

        internal static clsBook GetBookById(int bookId)
        {
            return clsBookTable.lstBook.Where(x => x.bookId == bookId).FirstOrDefault();
        }

        internal static bool RemoveBookById(clsBook bookToRemove)
        {
            return clsBookTable.lstBook.Remove(bookToRemove);
        }

        //internal static bool DeleteBook(int bookId)
        //{
        //    clsBookTable.lstBook.Remove()
        //}
    }
}