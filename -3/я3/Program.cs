using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace я3
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Введите значение для n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для k: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Введите значение для l: ");
            int l = int.Parse(Console.ReadLine());

            
            if (n + m > k)
            {
                if (n > k)
                {
                    if (m < l)
                    {
                        Console.WriteLine("Условие выполнено: n + m > k, и так как n > k, то m < l.");
                    }
                    else
                    {
                        Console.WriteLine("Условие не выполнено: n + m > k, но m >= l.");
                    }
                }
                else
                {
                    Console.WriteLine("Условие выполнено: n + m > k, и n <= k.");
                }
            }
            else
            {
                Console.WriteLine("Условие не выполнено: n + m <= k.");
            }
        }
    }
}
