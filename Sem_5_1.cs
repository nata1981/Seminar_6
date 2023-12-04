//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

 int[,] array = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = i + j;
                }
            }
            Console.WriteLine("Введите координаты элемента: ");
            string input = Console.ReadLine();
            string[] coords = input.Split(' ');
            if (coords.Length != 2)
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            int x = Convert.ToInt32(coords[0]);
            int y = Convert.ToInt32(coords[1]);
            if (x >= 0 && x < 3 && y >= 0 && y < 3)
            {
                Console.WriteLine($"Значение элемента с координатами ({x},{y}) равно {array[x, y]}");
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }