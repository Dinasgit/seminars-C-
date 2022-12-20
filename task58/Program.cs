// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

void InputMatrix1(int[, ] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(0, 11); 
            Console.Write($"{matrix1[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputMatrix2(int[, ] matrix2)
{
    for (int k = 0; k < matrix2.GetLength(0); k++)
    {
        for (int l = 0; l < matrix2.GetLength(1); l++)
        {
            matrix2[k, l] = new Random().Next(0, 11); 
            Console.Write($"{matrix2[k, l]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix1 = new int[coord[0], coord[1]];
int[,] matrix2 = new int[coord[0], coord[1]];
Console.WriteLine("Первая матрица: ");
InputMatrix1(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
InputMatrix2(matrix2);
Console.WriteLine("Произведение чисел матрицы: ");
int[, ] matrix = new int[coord[0], coord[1]];
for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = matrix1[m, n] * matrix2[m, n];
            Console.Write($"{matrix[m, n]} \t");
        }
        Console.WriteLine();
    }

