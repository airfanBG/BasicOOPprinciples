using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Books_Good
{
    public class Library
    {
        private IList<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public int FindBook(string title)
        {
            // logic for finding book
            return 1;
        }
    }
}
