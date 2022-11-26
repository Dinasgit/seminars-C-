// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
int d = ReadInt("Введите число от 1 до 7, относящееся ко дню недели: ");
Console.WriteLine(WorkHoliday(d));
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
if (a > 0 && a < 8)
{
if (a == 7 || a == 6)
{
Console.Write("Под цифрой " + a + " - Выходной");
}
else       
{
Console.Write("Под цифрой " + a + " - Рабочий");
}
}
else
{
Console.Write("Число не в пределах от 1 до 7, введите число, обозначающее");
}
    return " день.";
}