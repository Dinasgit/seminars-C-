// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - это палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - это не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не пятизначное число");
}