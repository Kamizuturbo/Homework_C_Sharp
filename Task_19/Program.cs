// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Clear();
// Console.WriteLine("Введите пятизначное число");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// if ((num1/10000) == (num1%10) && ((num1%10000)/1000) == ((num1%100)/10))
//     {
//         System.Console.WriteLine($"Число {num1} является полиндромом");
//     }
// else
//     {
//         System.Console.WriteLine($"Число {num1} не является полиндромом");
//     }



int Polindrome (int num1)
{
    if ((num1/10000) == (num1%10) && ((num1%10000)/1000) == ((num1%100)/10))
        {
            System.Console.WriteLine($"Число {num1} является полиндромом");
        }
    else
        {
            System.Console.WriteLine($"Число {num1} не является полиндромом");
        }
return num1;
}
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num1 = Convert.ToInt32 (Console.ReadLine());
System.Console.WriteLine(Polindrome(num1));