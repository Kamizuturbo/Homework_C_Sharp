// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumAllDigit (int num1)
{
    int result = 0;
    while (num1>0)
    {
        result+=num1%10;
        num1=num1/10;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine(SumAllDigit(num1));