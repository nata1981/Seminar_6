// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


  int[,] matrix = {{1, 2, 3},
                         {4, 5, 6},
                         {7, 8, 9}};

        swapRows(matrix, 0, matrix.GetUpperBound(0));

        Console.WriteLine("Swapped matrix:");
        foreach (var row in matrix) {
            Console.Write($"{String.Join(", ", row)} ");
        }
        Console.WriteLine();

    static void swapRows(int[,] matrix, int row1, int row2) {
        int temp;
        for (int col = 0; col < matrix.Get UpperBound(1); col++) {
            temp = matrix[row1, col];
            matrix[row1, col] = matrix[row2, col];
            matrix[row2, col] = temp;
        }
    }      
    