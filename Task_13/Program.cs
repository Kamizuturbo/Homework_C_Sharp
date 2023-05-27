// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
if (num<100)
    System.Console.WriteLine("Третьей цифры нет!");
else
{
    double i=10;
    double count=1;
    while (num/i<0)
    {
       i=Convert.ToDouble(Math.Pow(i,count));
       count=count+1;
       System.Console.WriteLine(count);
    }
count=count+1;
System.Console.WriteLine(count);
}
