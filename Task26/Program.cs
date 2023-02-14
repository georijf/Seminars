/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int GetAll(int number)
{
    if (number < 0) number = number * -1;
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

Console.Write("Введите число чтобы получить количество цифр в нём: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в этом числе: {GetAll(num)}");


