// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || num < 1)  Console.WriteLine("Введено нверное число ");
else if (num > 5) Console.WriteLine("да");
else Console.WriteLine("нет");
