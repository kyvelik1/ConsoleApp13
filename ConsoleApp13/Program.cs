using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1-30]");
            int input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:


                    Console.WriteLine("Введите значение A");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    int B = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение C");
                    int C = Convert.ToInt32(Console.ReadLine());

                    bool result = (A < 45 && B >= 45 && C >= 45) ||

                        (A >= 45 && B < 45 && C >= 45) ||

                        (A >= 45 && B >= 45 && C < 45);


                    if (result)
                    {
                        Console.WriteLine("Одно из чисел A, B, C меньше 45");

                    }

                    else
                    {
                        Console.WriteLine("Не одно из чисел не меньше 45");
                    }

                    Console.ReadKey();



                    break;

                case 2:

                    Console.WriteLine("Введите число A");
                    int A1 = Convert.ToInt32(Console.ReadLine());

                    if ((A1 % 10 != 0) && (A1 % 3 != 0))
                    {
                        Console.WriteLine($"Число {A1} не кратно трем, и не оканчивается на 0");
                    }
                    else
                    {
                        Console.WriteLine($"Условие {A1} ложное");
                    }

                    break;

                case 3:

                    Console.WriteLine("Введите число A");
                    int A2 = Convert.ToInt32(Console.ReadLine());

                    bool resault2 = (A2 <= -137 && A2 <= -51) || (A2 <= 123 && A2 <= 55);

                    if (resault2)
                    {
                        Console.WriteLine($"Число {A2} принадлежит одному из интервалов");
                    }

                    else
                    {
                        Console.WriteLine($"Число {A2} не принадлежит не одному из интервалов");
                    }




                    break;


                case 4:

                    Console.WriteLine("Введите значение X");
                    int X1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число Y");
                    int Y1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число Z");
                    int Z1 = Convert.ToInt32(Console.ReadLine());

                    bool result3 = (X1 % 5 == 0) || (Y1 % 5 == 0) || (Z1 % 5 == 0);

                    if (result3)
                    {
                        Console.WriteLine("Одно из чисел кратно 5");
                    }
                    else
                    {
                        Console.WriteLine("Не одно из числе не кратно 5");
                    }





                    break;

                case 5:

                    Console.WriteLine("Введите значение X");
                    int X2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение X");
                    int Y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение X");
                    int Z2 = Convert.ToInt32(Console.ReadLine());

                    bool result4 = (X2 > 80 || Y2 > 80 || Z2 > 80);
                    if (result4)
                    {
                        Console.WriteLine("Одно из чисел больше 80");
                    }
                    else
                    {

                        Console.WriteLine("Не один из чисел не больше 80");
                    }


                    break;

                case 6:
                    Console.WriteLine("Введите значение A");
                    int A3 = Convert.ToInt32(Console.ReadLine());
                    bool resault5 = !(A3 >= 10 && A3 <= 1) && !(A3 >= 2 && A3 <= 15);
                    if (resault5)
                    {
                        Console.WriteLine($"Число {A3} не пренадлежит от ..... ......");
                    }
                    else
                    {

                        Console.WriteLine($"Число {A3} пренадлежит от ..... ......");
                    }

                    break;

                case 7:
                    Console.WriteLine("Введите значение A");
                    int A4 = Convert.ToInt32(Console.ReadLine());

                    bool resailt6 = (A4 >= 1000 && A4 <= 9999 && A4 != 4999);
                    if (resailt6)
                    {
                        Console.WriteLine($"Число {A4} является четырехзначным, и не равно 4999");
                    }
                    else
                    {
                        Console.WriteLine($"Число {A4} не является четырехзначным, либо равно 4999");
                    }


                    break;


                case 8:

                    Console.WriteLine("Введите значение A");
                    int A5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    int B5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение D");
                    int C5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение C");
                    int D5 = Convert.ToInt32(Console.ReadLine());
                    bool resault = (A5 * D5 > C5 * B5) || (A5 * D5 < C5 * B5);
                    if (resault)
                    {
                        Console.WriteLine($"Дробь A/B ({A5}/{B5}) больше дроби C/D ({C5}/{D5}).");
                    }
                    else
                    {
                        Console.WriteLine($"Дробь C/D ({C5}/{D5}) больше дроби A/B ({A5}/{B5}).");
                    }



                    break;

                    case 9:

                    Console.WriteLine("Введите значение X");
                    int X = Convert.ToInt32(Console.ReadLine());

                    bool result7 = (X <= 0 || X >= 5);

                    if (result7)
                    {
                        Console.WriteLine("Условие истино");
                    }
                    else
                    {
                        Console.WriteLine("Условие ложное");
                    }

                    



                    break;

                    case 10:

                    Console.WriteLine("Введите значение Y");
                    int Y3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение X");
                    int X3 = Convert.ToInt32(Console.ReadLine());

                    bool result8 = (Y3 >= 0 && Y3 <= 6 || X3 < 7);

                    if (result8)
                    {
                        Console.WriteLine("Условие истино");
                    }
                    else
                    {
                        Console.WriteLine("Условие ложное");
                    }

                    break;


                    case 11:



                    break;



            }
        }
    }
}
                 
