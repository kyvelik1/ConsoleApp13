using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d13
{

    class MatrixReflector
    {
        private int[,] matrix;
        private int size;

        public MatrixReflector(int[,] inputMatrix)
        {
            if (inputMatrix.GetLength(0) != inputMatrix.GetLength(1))
            {
                throw new ArgumentException("Матрица должна быть квадратной.");
            }

            size = inputMatrix.GetLength(0);
            matrix = new int[size, size];
            Array.Copy(inputMatrix, matrix, inputMatrix.Length);
        }

        public void ReflectOverSecondaryDiagonal()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[size - j - 1, size - i - 1];
                    matrix[size - j - 1, size - i - 1] = temp;
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
            int[,] inputMatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            MatrixReflector reflector = new MatrixReflector(inputMatrix);

            Console.WriteLine("Исходная матрица:");
            reflector.PrintMatrix();

            reflector.ReflectOverSecondaryDiagonal();

            Console.WriteLine("\nМатрица после отражения относительно побочной диагонали:");
            reflector.PrintMatrix();
        }
    }
}
