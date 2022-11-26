// 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёхзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 99 || n > 1000)
{
Console.WriteLine("Вы ввели не трёхзначное число");
}
else
{
Console.WriteLine(InCenter(n));
}
int ReadInt(string message)
{
Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
int result = ((a / 10) % 10);
return result;
}
