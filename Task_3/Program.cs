using System;

// * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
// Написать программу, демонстрирующую все разработанные элементы класса.
// * Добавить свойства типа int для доступа к числителю и знаменателю;
// * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// ** Добавить проверку, чтобы знаменатель не равнялся 0.
// Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.
//
// Лузиков Иван

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions x1 = new Fractions(1,4);
            Fractions x2 = new Fractions(1,8);

            Console.WriteLine($"{x1.m} / {x1.n}");
            Console.WriteLine($"{x2.m} / {x2.n}");

            Fractions xSum = Fractions.Sum(x1,x2);
            Console.WriteLine($"Сумма = {xSum.m} / {xSum.n}");
            Console.WriteLine("НОД = " + Fractions.Nod(xSum.m, xSum.n));
            Fractions reduce = Fractions.Reduce(xSum);
            Console.WriteLine($"Сокращение дроби: {reduce.m} / {reduce.n}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nПрограмма завершена");
            Console.ReadKey();
        }
    }
}
