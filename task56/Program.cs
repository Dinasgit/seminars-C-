// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
int[] array = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{   
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        sum += matrix [i, j];
        }
array[i] = (sum);
}
Console.WriteLine("Суммы каждой строки по порядку:");
Console.WriteLine($"[{string.Join(",\t", array)}]");
int index = 0;
int min = array[0];
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
    }
Console.WriteLine($"Строка с меньшей суммой элементов: {index + 1} строка");


