using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            //                       Задание 2:      Написать рекурсивную функцию нахождения наибольшего общего делителя двух целых чисел.


            



            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введите первое число: ");
            int chislo1 = int.Parse(Console.ReadLine());

            Console.Write("Введите втовое число: ");
            int chislo2 = int.Parse(Console.ReadLine());



            int result = NOD(chislo1, chislo2);

            Console.Write("Наибольший общий делитель = " + result);


        }

        static int NOD(int a, int b)
        {

            if (a == 0 || b == 0)
                return a + b;

            else
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }

                return NOD(a, b);


            }


        }
    }
}
