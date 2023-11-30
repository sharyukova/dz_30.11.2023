using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12.classes
{
    class Book
    {
        public string Title;
        public string Author;
        public string Publisher;

        /// <summary>
        /// Создает объект "книга"
        /// </summary>
        /// <param name="title">название книги</param>
        /// <param name="author">её автор</param>
        /// <param name="publisher">издательство</param>
        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }
    }
}