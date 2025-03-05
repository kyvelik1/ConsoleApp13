using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d15
{
    class Program
    {
        static void Main()
        {
            int n = 4; // Размер массива
            int[,] A = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                    {
                        A[i, j] = 1; // Диагональ из правого верхнего в левый нижний угол
                    }
                    else if (i + j < n - 1)
                    {
                        A[i, j] = 0; // Выше диагонали
                    }
                    else
                    {
                        A[i, j] = 2; // Ниже диагонали
                    }
                }
            }

            // Вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
