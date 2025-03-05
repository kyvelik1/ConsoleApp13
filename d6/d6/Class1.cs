using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6
{
    class MatrixSimilarityChecker
    {
        private int[,] matrix;
        private int M, N;

        public MatrixSimilarityChecker(int[,] matrix)
        {
            this.matrix = matrix;
            M = matrix.GetLength(0);
            N = matrix.GetLength(1);
        }

        public int CountRowsSimilarToFirst()
        {
            if (M == 0 || N == 0)
                return 0;

            // Получаем множество чисел из первой строки
            var firstRowSet = new HashSet<int>();
            for (int j = 0; j < N; j++)
            {
                firstRowSet.Add(matrix[0, j]);
            }

            int count = 0;

            // Сравниваем каждую строку с первой
            for (int i = 0; i < M; i++)
            {
                var currentRowSet = new HashSet<int>();
                for (int j = 0; j < N; j++)
                {
                    currentRowSet.Add(matrix[i, j]);
                }

                if (currentRowSet.SetEquals(firstRowSet))
                {
                    count++;
                }
            }

            return count;
        }
    }

    class Program
    {
        static void Main()
        {
            int[,] matrix = {
            {1, 2, 3, 4},
            {2, 3, 4, 1},
            {5, 6, 7, 8},
            {1, 2, 3, 4},
            {4, 3, 2, 1}
        };

            MatrixSimilarityChecker checker = new MatrixSimilarityChecker(matrix);
            int similarRowsCount = checker.CountRowsSimilarToFirst();

            Console.WriteLine($"Количество строк, похожих на первую: {similarRowsCount}");
        }
    }
}
