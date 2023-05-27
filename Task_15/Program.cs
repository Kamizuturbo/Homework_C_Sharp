// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7 включительно");
int num = Convert.ToInt32 (Console.ReadLine());
if (num>5)
    System.Console.WriteLine("Да!");
else
    System.Console.WriteLine("Нет!");