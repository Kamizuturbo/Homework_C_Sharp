// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16

double Power (double num1,double num2)
{
    double PowerNum1=Convert.ToDouble(Math.Pow(num1,num2));
    return PowerNum1;
}
Console.Clear();
Console.WriteLine("Введите число А");
double num1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите число B");
double num2 = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine(Power(num1,num2));