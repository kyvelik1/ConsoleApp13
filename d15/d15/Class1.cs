using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d15
{
    class MatrixCreator
    {
        private int[,] matrix;
        private int size;

        public MatrixCreator(int n)
        {
            size = n;
            matrix = new int[size, size];
            FillMatrix();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i + j == size - 1)
                    {
                        matrix[i, j] = 1; // Диагональ из правого верхнего в левый нижний угол
                    }
                    else if (i + j < size - 1)
                    {
                        matrix[i, j] = 0; // Выше диагонали
                    }
                    else
                    {
                        matrix[i, j] = 2; // Ниже диагонали
                    }
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            int n = 4; // Размер массива
            MatrixCreator creator = new MatrixCreator(n);
            creator.PrintMatrix();
        }
    }
}
