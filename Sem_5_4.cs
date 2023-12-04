// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
 // на пересечении которых расположен наименьший элемент массива.
 // Под удалением понимается создание нового двумерного массива без строки и столбца

         int[,] matrix = {{1, 2, 3},
                         {4, 5, 6},
                         {7, 8, 9}};

        int minValue = int.MaxValue;
        int minRow = -1;
        int minCol = -1;

        for (int i = 0; i < matrix.GetUpperBound(0); i++)
        {
            for (int j = 0; j < matrix.GetUpperBound(1); j++)
            {
                if (matrix[i, j] < minValue)
                {
                    minValue = matrix[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        int[,] result = new int[matrix.GetUpperBound(0) - 1][matrix.GetUpperBound(1) - 1];

        for (int i = 0; i < matrix.GetUpperBound(0); i++)
        {
            if (i != minRow)
            {
                for (int j = 0; j < matrix.GetUpperBound(1); j++)
                {
                    if (j != minCol)
                    {
                        result[i][j] = matrix[i, j];
                    }
                }
            }
        }

        Console.WriteLine("Матрица после удаления строки и столбца:");
        PrintMatrix(result);

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetUpperBound(0); i++)
        {
            for (int j = 0; j < matrix.GetUpperBound(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }