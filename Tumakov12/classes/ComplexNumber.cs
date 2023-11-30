using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12
{
    class ComplexNumber
    {
        private double Real;
        private double Imaginary;

        /// <summary>
        /// конструктор создает комплексное число вида 'z + bi', где 'z' - вещественная часть, 'bi' - мнимая часть
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        /// <summary>
        /// находит сумму двух комплексных чисел
        /// </summary>
        /// <param name="c1">первое число</param>
        /// <param name="c2">второе число</param>
        /// <returns></returns>
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        /// <summary>
        /// находит разность двух комплексных чисел
        /// </summary>
        /// <param name="c1">первое число</param>
        /// <param name="c2">второе число</param>
        /// <returns></returns>
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        /// <summary>
        /// находит произведение двух комплексных чисел
        /// </summary>
        /// <param name="c1">первое число</param>
        /// <param name="c2">второе число</param>
        /// <returns></returns>
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new ComplexNumber(real, imaginary);
        }

        /// <summary>
        /// проверяет равенство чисел, выводит значение типа bool
        /// </summary>
        /// <param name="c1">первое число</param>
        /// <param name="c2">второе число</param>
        /// <returns></returns>
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        /// <summary>
        /// проверяет неравенство чисел, выводит значение типа bool
        /// </summary>
        /// <param name="c1">первое число</param>
        /// <param name="c2">второе число</param>
        /// <returns></returns>
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            if (Imaginary >= 0)
            {
                return $"{Real} + {Imaginary}i";
            }
            else
            {
                return $"{Real} - {-Imaginary}i";
            }
        }
    }
}
