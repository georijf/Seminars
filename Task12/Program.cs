/* 12. Напишите программу, 
1. которая будет принимать на
вход два числа и 
2. выводить, является ли первое число
кратным второму. 
3. Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

int IsMultipleWithRemainder(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine(num1 + " кратно " + num2);
        int result = 0;
        return result;
    }
    else
    {
        Console.WriteLine(num1 + " не кратно " + num2 + ", остаток от деления " + (num1 % num2));
        return num1 % num2;
    }
}

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsMultipleWithRemainder(x, y));

/* bool IsMultipleWithRemainder(int num1, int num2)
{
    int result = num1 % num2;
    return num1 % num2 == 0;
} */


/* bool IsMultipleWithRemainder(int x, int y)
{
    int remainder = x % y;
    if (remainder == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
} */

