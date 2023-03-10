using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Books_Good
{
    public class BookPagination
    {
        private readonly Book book;

        public BookPagination(Book book)
        {
            this.book = book;
        }
        public int GetPage(int page)
        {
            return book.Pages[page];
        }
    }
}
