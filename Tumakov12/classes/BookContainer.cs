using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12.classes
{
    internal class BookContainer
    {
        private Book[] books;

        public BookContainer(Book[] books)
        {
            this.books = books;
        }

        // Метод сортировки книг
        public void SortBooks(Comparison<Book> comparison) ///  Делегат Comparison<Book> используется для 
                                                           ///  сортировки массива книг по определенному критерию
        {
            Array.Sort(books, comparison);
        }
    }
}
