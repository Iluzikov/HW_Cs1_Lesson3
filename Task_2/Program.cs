using System;
using System.Collections.Generic;

// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
// Требуется подсчитать сумму всех нечётных положительных чисел.
// Сами числа и сумму вывести на экран, используя tryParse.
//
// Лузиков Иван

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // "Сами числа и сумму вывести на экран"
            // Ума не приложу как "Сами числа" можно вывести на экран без использования списка
            List<int> oddNumbersList = new List<int>();

            Console.WriteLine("Вводите числа, для завершения введите \"0\"");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int userInput))
                {
                    if (userInput == 0)
                        break;
                    else if (userInput > 0 && userInput % 2 != 0)
                        oddNumbersList.Add(userInput);
                }
            }

            Console.Write("Нечётные числа введенные вами: ");
            foreach (int num in oddNumbersList)
            {
                Console.Write(num + " ");
                sum += num;
            }
            Console.WriteLine("\nСумма этих чисел = " + sum);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nПрограмма завершена");
            Console.ReadKey();
        }
    }
}
