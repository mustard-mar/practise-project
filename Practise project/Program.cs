using System;

namespace Practise_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Число пи приближенное
            BigIntForPi bifp = new BigIntForPi(100);
            bifp.divide();
            Console.WriteLine("Число пи:\n" + bifp);
            //Числа Фибоначчи
            Fibonacci_number fn = new Fibonacci_number(70);
            fn.calc();
            Console.WriteLine("Числа Фибоначчи:\n" + fn);
            //Разложение на простые делители со степенями
            PrimeDividers pd = new PrimeDividers(997);
            pd.calc();

        }
    }
}
