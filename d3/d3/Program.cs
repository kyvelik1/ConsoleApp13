using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d3
{
  
        class Program
        {
            static void Main()
            {
                int size = 5; // Размер массива (можно изменить)
                int[,] L = new int[size, size];
                Random random = new Random();

                // Заполнение массива случайными числами
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        L[i, j] = random.Next(-100, 100); // Диапазон случайных чисел
                    }
                }

                // Увеличение каждого элемента в 3 раза и смена знака
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        L[i, j] = -L[i, j] * 3;
                    }
                }

                // Вывод массива на экран в виде таблицы
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(L[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    
}
