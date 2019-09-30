using System;

// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//
// Лузиков Иван

namespace Task_1a
{

    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(5, -6);
            Complex z2 = new Complex(-3, 2);
            Complex z3 = Complex.Difference(z1, z2);

            // вариант а) вычитание комплексных чисел.
            Console.WriteLine($"Разность комплексных чисел: ({z1.PrintComplex()}) - ({z2.PrintComplex()}) =  {z3.PrintComplex()}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nПрограмма завершена");
            Console.ReadKey();
        }
    }
}
