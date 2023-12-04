// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

  int[,] matrix = {{1, 2, 3},
                         {4, 5, 6},
                         {7, 8, 9}};

        int minSumRow = FindMinSumRow(matrix);
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");

    static int FindMinSumRow(int[,] matrix)
    {
        int minSum = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < matrix.GetUpperBound(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetUpperBound(1); j++)
            {
                sum += matrix[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
        }

        return minIndex;
    }