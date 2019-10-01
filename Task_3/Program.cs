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
            Fractions f1 = new Fractions(5,6);
            Fractions f2 = new Fractions(2,3);
            
            Console.WriteLine("Первое рациональное число: " + f1.PrintF());
            Console.WriteLine("Второе рациональное число: " + f2.PrintF());
            Console.WriteLine();

            Fractions fSum = Fractions.Sum(f1,f2);
            Console.Write($"Результат сложения = {fSum.PrintF()}");
            fSum.Reduce();
            Console.WriteLine($" -> упрощение дроби {fSum.PrintF()}");

            Fractions fDifference = Fractions.Difference(f1, f2);
            fDifference.Reduce();
            Console.WriteLine($"Результат вычитания = {fDifference.PrintF()}");

            Fractions fMultiply = Fractions.Multiply(f1, f2);
            fMultiply.Reduce();
            Console.WriteLine($"Результат умножения = {fMultiply.PrintF()}");

            Fractions fDivision = Fractions.Division(f1, f2);
            fDivision.Reduce();
            Console.WriteLine($"Результат деления = {fDivision.PrintF()}");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nПрограмма завершена");
            Console.ReadKey();
        }
    }
}
