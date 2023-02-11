/*
Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999 && IsPalindrome(number))
{
    Console.WriteLine("Введено пятизначное число, и оно является палидромом");
}
else
{
    Console.WriteLine("Число не является палидромом, или введено не пятизначное число");
}


bool IsPalindrome(int number)
{
    int originalNumber = number;
    int reverseNumber = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        reverseNumber = reverseNumber * 10 + lastDigit;
        number = number / 10;
    }
    return originalNumber == reverseNumber;
}
