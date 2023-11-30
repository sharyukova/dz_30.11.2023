using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov12.classes;

namespace Tumakov12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.2 Создать класс рациональных чисел. В классе два поля – числитель и\r\nзнаменатель. Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <,\r\n>, <=, >=, +, – , ++, --. Переопределить метод ToString() для вывода дроби. Определить\r\nоператоры преобразования типов между типом дробь, float, int. Определить операторы *, /,\r\n%.");

            RationalNumber rational1 = new RationalNumber(2, 3);
            RationalNumber rational2 = new RationalNumber(1, 2);


            Console.WriteLine(rational1 == rational2); 
            Console.WriteLine(rational1 != rational2); 

            Console.WriteLine(rational1 < rational2);
            Console.WriteLine(rational1 > rational2);
            Console.WriteLine(rational1 <= rational2); 
            Console.WriteLine(rational1 >= rational2);

            Console.WriteLine(rational1 * rational2);
            Console.WriteLine(rational1 / rational2);
            Console.WriteLine(rational1 % rational2);

            Console.WriteLine(rational1.ToString());
            Console.WriteLine(rational2.ToString());

            float r1 = rational1;
            int r2 = rational2;
            Console.WriteLine(r1 + " " + r2);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------\n");

            
            Console.WriteLine();
            Console.WriteLine("Домашнее задание 12.1 На перегрузку операторов. Описать класс комплексных чисел.\r\nРеализовать операцию сложения, умножения, вычитания, проверку на равенство двух\r\nкомплексных чисел. Переопределить метод ToString() для комплексного числа.\r\nПротестировать на простом примере.");
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(2, 5);

            Console.WriteLine($"c1: {c1}");
            Console.WriteLine($"c2: {c2}");

            Console.WriteLine($"c1 + c2: {c1 + c2}");
            Console.WriteLine($"c1 - c2: {c1 - c2}");
            Console.WriteLine($"c1 * c2: {c1 * c2}");

            Console.WriteLine($"c1 == c2: {c1 == c2}");
            Console.WriteLine($"c1 != c2: {c1 != c2}");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine();
            Console.WriteLine();

            Book[] books = new Book[]
            {
            new Book("Ночь в Лиссабоне", "Ремарк Э.М.", "Neoclassic"),
            new Book("Мастер и Маргарита", "Булгаков М. А.", "АСТ"),
            new Book("Оппенгеймер. Триумф и трагедия Американского Прометея", "Берд К, Шервин М.", "АСТ")
            };

            BookContainer container = new BookContainer(books);

            // Сортировка по названию книги
            container.SortBooks((b1, b2) => b1.Title.CompareTo(b2.Title));

            // Вывод отсортированных книг
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}");
            }
        }
    }
}
