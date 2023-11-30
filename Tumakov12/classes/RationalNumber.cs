using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12
{
    // 12.2 
    class RationalNumber
    {
        private int numerator;
        private int denominator;

        /// <summary>
        /// конструктор вызывает рациональное число вида "a/b", где a - числитель, b - знаменатель 
        /// </summary>
        /// <param name="numerator">числитель</param>
        /// <param name="denominator">знаменатель !!! замечание: он является натуральным числом</param>
        /// <exception cref="ArgumentException"></exception>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator <= 0)
            {
                throw new ArgumentException("Знаменатель не может равняться нулю или быть меньше нуля. Знаменатель - натуральное число (из определения)");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }


        /// <summary>
        /// проверяет, являются ли эти числа равными, и возвращает значение типа bool
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return r1.Equals(r2);
        }

        /// <summary>
        /// проверяет, являются ли эти числа неравными, и возвращает значение типа bool
        /// </summary>
        /// <param name="r1"> первое число </param>
        /// <param name="r2">второе число</param>
        /// <returns></returns>
        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !r1.Equals(r2);
        }


        /// <summary>
        /// оператор сравнения
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) < (r2.numerator * r1.denominator);
        }


        /// <summary>
        /// оператор сравнения
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) > (r2.numerator * r1.denominator);
        }


        /// <summary>
        /// оператор сравнения
        /// </summary>
        /// <param name="r1">первое число</param>
        /// <param name="r2">второе число</param>
        /// <returns></returns>
        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) <= (r2.numerator * r1.denominator);
        }


        /// <summary>
        /// оператор сравнения
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) >= (r2.numerator * r1.denominator);
        }


        /// <summary>
        /// складывает два рациональных числа
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            int newNumerator = (r1.numerator * r2.denominator) + (r2.numerator * r1.denominator);
            int newDenominator = r1.denominator * r2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        /// <summary>
        /// находит разность двух рациональных чисел
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            int newNumerator = (r1.numerator * r2.denominator) - (r2.numerator * r1.denominator);
            int newDenominator = r1.denominator * r2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }


        /// <summary>
        /// прибавляет к числу единицу
        /// </summary>
        /// <param name="r">рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator ++(RationalNumber r)
        {
            return new RationalNumber(r.numerator + r.denominator, r.denominator);
        }


        /// <summary>
        /// вычитает из числа единицу
        /// </summary>
        /// <param name="r">рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator --(RationalNumber r)
        {
            return new RationalNumber(r.numerator - r.denominator, r.denominator);
        }

        public static implicit operator float(RationalNumber r)
        {
            return (float)r.numerator / r.denominator;
        }

        public static implicit operator int(RationalNumber r)
        {
            return r.numerator / r.denominator;
        }


        /// <summary>
        /// находит произведение двух рациональных чисел
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
        }

        /// <summary>
        /// находит целую часть от деления двух рациональных чисел
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.numerator * r2.denominator, r1.denominator * r2.numerator);
        }


        /// <summary>
        /// находит остаток от деления двух рациональных чисел
        /// </summary>
        /// <param name="r1">первое рациональное число</param>
        /// <param name="r2">второе рациональное число</param>
        /// <returns></returns>
        public static RationalNumber operator %(RationalNumber r1, RationalNumber r2)
        {
            int result = (r1.numerator * r2.denominator) % (r1.denominator * r2.numerator);
            return new RationalNumber(result, 1);
        }


        /// <summary>
        /// метод переводит число в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}
