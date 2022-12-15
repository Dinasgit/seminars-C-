// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void InputMatrix(double[,] matrix, int minNumber = (-10), int maxNumber = 10 )
{
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * new Random().Next(minNumber, maxNumber + 1), 2);

            Console.Write($"{matrix[i,j]}\t");
        }        
    Console.WriteLine($"\n");
    }
}

Console.Clear();
Console.Write("Введите размер матрицы одной строкой через пробел: ");
string[] arrayVolume = Console.ReadLine().Split(" ");

int row = int.Parse(arrayVolume[0]);
int column = int.Parse(arrayVolume[1]);

double[,] matrix = new double[row,column];

InputMatrix(matrix);