using System;
using System.Text;

namespace Zadacha4.Rekursiya
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Задание 4:      Написать функцию, которая получает в качестве параметров 2 целых числа 
            //   и возвращает сумму чисел из диапазона между ними.Рекурсия.


            Console.OutputEncoding = Encoding.UTF8;

            do
            {

                Console.Write("Введите первое число: ");
            int Nomer1 = int.Parse(Console.ReadLine());



                Console.Write("Введите второе число: ");
            int Nomer2 = int.Parse(Console.ReadLine());

            
            int c = 0;
            int d = 0;
            
            if (Nomer1 - Nomer2 > 1)
            {
                c = Nomer2+1 ;
                int result = Summa(Nomer2, Nomer1, c, d);
               Console.WriteLine($"Сумма чисел из диапазона:{Nomer1} и {Nomer2} : " + result);
                break;
            }

            else if (Nomer2 - Nomer1 > 1)
            {
                c = Nomer1+1;
                int result = Summa(Nomer1, Nomer2, c, d );
                Console.WriteLine($"Сумма чисел из диапазона {Nomer1} и {Nomer2} : " + result);
                break;
            }
                else
                {
                    Console.WriteLine("В Задаче указано, что нужно посчитать сумму чисел в диапазоне двух целых чисел. \nПоэтому, первое число должно отличаться от второго минимум на 3 единицы. Будьте внимательны");
                }

                Console.WriteLine();

            } while (true);

            
        }


        static int Summa(int a, int b, int c , int d )
            
        {
              
           
            if (c == b)
            {

                return d;
            }


            else
            {
                a = a + 1;
                d = d + a;
                return Summa(a,b,c+1,d);
            }

        }
    }
}

