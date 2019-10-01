using System;

namespace Task_3
{
    class Fractions
    {
        private int m;
        public int M
        {
            get { return m; }
            private set { m = value; }
        }

        private int n;
        public int N
        {
            get { return n; }
            private set
            { 
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                else
                    n = value;
            }
        }
        
        public Fractions(int m, int n)
        {
            M = m;
            N = n;
        }

        /// <summary>
        /// Вывод дроби
        /// </summary>
        /// <returns></returns>
        public string PrintF()
        {
            if (M > N)
            {
                int numerator = M % N;
                int intPart = M / N;
                return $"{intPart}({numerator}/{N})";
            }
            else
                return N == 1 ? $"{M}" : $"{M}/{N}";
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="F1"></param>
        /// <param name="F2"></param>
        /// <returns></returns>
        public static Fractions Sum(Fractions F1, Fractions F2)
        {
            if (F1.N == F2.N)
                return new Fractions(F1.M + F2.M, F1.N);
            else
                return new Fractions((F2.N * F1.M + F1.N * F2.M), F1.N * F2.N);
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="F1"></param>
        /// <param name="F2"></param>
        /// <returns></returns>
        public static Fractions Difference(Fractions F1, Fractions F2)
        {
            if (F1.N == F2.N)
                return new Fractions(F1.M - F2.M, F1.N);
            else
                return new Fractions((F2.N * F1.M - F1.N * F2.M), F1.N * F2.N);
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="F1"></param>
        /// <param name="F2"></param>
        /// <returns></returns>
        public static Fractions Multiply(Fractions F1, Fractions F2)
        {
            return new Fractions(F1.M * F2.M, F1.N * F2.N);
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="F1"></param>
        /// <param name="F2"></param>
        /// <returns></returns>
        public static Fractions Division(Fractions F1, Fractions F2)
        {
            return new Fractions(F1.M * F2.N, F1.N * F2.M);
        }

        /// <summary>
        /// Сокращение дроби
        /// </summary>
        public void Reduce()
        {
            int nod = Nod(M, N);
            M = M / nod;
            N = N / nod;
        }

        /// <summary>
        /// Получение наибольшего общего делителя
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Nod(int a, int b)
        {
            return (b != 0) ? Nod(b, a % b) : a;
        }


    }
}
