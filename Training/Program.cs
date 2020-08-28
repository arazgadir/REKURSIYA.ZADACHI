using System;
using System.Net.Http.Headers;

namespace ZADACHA._6
{
    class Program
    {
        static void Main(string[] args)
        {

            //                       Задание 3:      Написать рекурсивную функцию нахождения степени числа.
           
            Console.Write("Vvedite chislo: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("V kakuyu stepen vozvesti ?: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;

            int Result = Stepen(a, b, c);                   

            Console.Write(Result);
        }

        static int Stepen(int a, int b, int c)
        {

            if ((a == 0) && (b == 0))
            {
                return 1;
            }

            else if (b == 0)
            {
                return 1;
            }


            else if (a == 0)
            {
                return 0;
            }

            else if (b == 1)
            {
                return a;
            }

            else
            {
                return Stepen((a) * c, b - 1, c);
            }
            

        }

    }
}
