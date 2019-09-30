using System;

namespace Task_3
{
    class Fractions
    {
        public int m, n;

        public Fractions(int M, int N)
        {
            m = M;
            n = N;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static Fractions Sum(Fractions x1, Fractions x2)
        {
            if (x1.n == x2.n)
            {
                return new Fractions(x1.m + x2.m, x1.n);
            } else
            {
                var denominator = x1.n * x2.n;
                return new Fractions((x2.n * x1.m + x1.n * x2.m), denominator);
            }
        }
        public static Fractions Reduce(Fractions F)
        {
            int nod = Nod(F.m, F.n);
            return new Fractions(F.m / nod, F.n / nod);
        }

        public static int Nod(int a, int b)
        {
            return (b != 0) ? Nod(b, a % b) : a;
        }


    }
}
