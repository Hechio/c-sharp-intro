using System;
namespace Hello_world
{
    public class Book
    {
      
        private string title;
        private string author;
        private int pages;

        public static int bookCount = 0;

        public Book(string aName, string aAuthor, int aPages)
        {
            title = aName;
            author = aAuthor;
            Pages = aPages;
            bookCount++;
        }

        public Book()
        {
        }


        public bool MorePages() {
            if (pages > 100) {
                return true;
            }
            return false;
        }

        public int Pages
        {
            get { return pages; }
            set {
                if (value > 1000) {
                    pages = value;
                }else { pages = 1000; }
            }
        }
    }
}
