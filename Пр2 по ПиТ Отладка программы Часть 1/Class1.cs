using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр2_по_ПиТ_Отладка_программы_Часть_1
{
    internal class Class1
    {
        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }

        static void Main(string[] args)
        {
            int result = Fibonacci(8);
            Console.WriteLine(result);
        }
    }
}
