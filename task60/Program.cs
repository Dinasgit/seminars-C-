// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

void Input3DMatrix(int[, , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int val1 = i;
        Console.WriteLine($"Страница {i + 1}");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int val2 = j;
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int val3 = k;
                matrix[i, j, k] = new Random().Next(0, 11); 
                Console.Write($"{matrix[i, j, k]} {(val1, val2, val3)} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер трёхмерного массива: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[, , ] matrix = new int[coord[0], coord[1], coord[2]];
Input3DMatrix(matrix);
