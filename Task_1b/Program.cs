using System;

// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.
//
// Лузиков Иван

namespace Task_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(-6, 5);
            Complex z2 = new Complex(2, -3);
            Complex zDif = Complex.Difference(z1, z2);
            Complex zMult = Complex.Multiply(z1, z2);
            
            // Вариант б) Проверить работу класса.
            Console.WriteLine($"Комплексные числа:\nпервое число ({z1.PrintComplex()})\nвторое число ({z2.PrintComplex()})");
            Console.WriteLine();

            // Вариант в) Добавить диалог с использованием switch
            Console.WriteLine("Для получения разности чисел ввидите \"1\", для получения произведения чисел впишите \"2\", для выхода введите \"0\" ");
            var userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1": Console.WriteLine($"Разность комплексных чисел: ({z1.PrintComplex()}) - ({z2.PrintComplex()}) = {zDif.PrintComplex()}");
                    break;
                case "2": Console.WriteLine($"Произведение комплексных чисел: ({z1.PrintComplex()}) * ({z2.PrintComplex()}) = {zMult.PrintComplex()}");
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Вы ввыели не верное число.");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
