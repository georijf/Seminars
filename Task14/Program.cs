/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

bool Mult(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
bool mult = Mult(num1);
Console.WriteLine(mult ? "ДА" : "НЕТ");

