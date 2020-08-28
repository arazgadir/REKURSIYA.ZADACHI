using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Zadacha5.Rekursiya
{
                                            // Задание 5:      Написать программу, которая выдает день недели на английском языке по номеру дня недели.
    enum Days 
    {

        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
        Error = 8
    }


    class Program
    { 

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
   
                Console.Write("Выберите день недели: ");
                int den = int.Parse(Console.ReadLine());
                Days op;
                Console.WriteLine();
         
                switch (den)
                    {
                        case 1:
                                op = Days.Monday;
                                //Console.WriteLine(op);
                                break;

                        case 2:
                                op = Days.Tuesday;
                                //Console.WriteLine(op);
                                break;

                        case 3:
                                op = Days.Wednesday;
                                //Console.WriteLine(op);
                                break;

                        case 4:
                                op = Days.Thursday;
                                //Console.WriteLine(op);
                                break;

                        case 5:
                                op = Days.Friday;
                                //Console.WriteLine(op);
                                break;

                        case 6:
                    
                                op = Days.Saturday;
                                //Console.WriteLine(op);
                                break;
                    
                        case 7:
                                op = Days.Sunday;
                                //Console.WriteLine(op);
                                break;

                       default:
                                Console.WriteLine("Выберите числа от 1 до 7");
                                op = Days.Error;
                                break;        

                    }
            
            Console.WriteLine(op);
        }

    }
 }






//do
//{


//    Console.WriteLine("Viberite Den nedeli :");
//    int num = int.Parse(Console.ReadLine());
//    Days op;

//    switch (num)
//    {
//        case 1:
//            op = Days.Monday;
//            break;

//        case 2:
//            op = Days.Tuesday;
//            break;

//        case 3:
//            op = Days.Wednesday;
//            break;

//        case 4:
//            op = Days.Thursday;
//            break;

//        case 5:
//            op = Days.Friday;
//            break;

//        case 6:
//            op = Days.Saturday;
//            break;

//        case 7:
//            op = Days.Sunday;
//            break;


//            Console.WriteLine(op);
//    }
//    while (true) ;