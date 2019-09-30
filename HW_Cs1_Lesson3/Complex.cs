﻿using System;

// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.
//
// Лузиков Иван

namespace Task_1a
{
    struct Complex
    {
        public double a, b;

        public Complex(double A, double B)
        {
            a = A;
            b = B;
        }

        public static Complex Difference(Complex Z1, Complex Z2)
        {
            // z = (a1 - a2)+(b1 - b2)i
            return new Complex(Z1.a - Z2.a, Z1.b - Z2.b);
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
