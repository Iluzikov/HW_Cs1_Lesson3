using System;

// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.
//
// Лузиков Иван

namespace Task_1b
{
    class Complex
    {
        public double a, b;

        public Complex(double A, double B)
        {
            a = A;
            b = B;
        }

        /// <summary>
        /// Вычисление разницы комплексных чисел
        /// </summary>
        /// <param name="Z1"></param>
        /// <param name="Z2"></param>
        /// <returns></returns>
        public static Complex Difference(Complex Z1, Complex Z2)
        {
            // z = (a1 - a2)+(b1 - b2)i
            return new Complex(Z1.a - Z2.a, Z1.b - Z2.b);
        }

        /// <summary>
        /// Вычисление произведения комплексных чисел
        /// </summary>
        /// <param name="Z1"></param>
        /// <param name="Z2"></param>
        /// <returns></returns>
        public static Complex Multiply(Complex Z1, Complex Z2)
        {
            // z = (a1*a2 - b1*b2) + (a1*b2 + b1*a2)
            return new Complex(Z1.a * Z2.a - Z1.b * Z2.b, Z1.a * Z2.b + Z1.b * Z2.a);
        }

        /// <summary>
        /// Вывод комплексного числа
        /// </summary>
        /// <returns></returns>
        public string PrintComplex()
        {
            return b < 0 ? $"{a} - {Math.Abs(b)}i" : $"{a} + {b}i";
        }
    }
}
