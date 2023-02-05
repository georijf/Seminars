/* 9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8 */

int numb = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число в диопазоне от 10 до 99: {numb}");

int maxDigit = MaxDigit(numb);
Console.WriteLine($"Наибольшая цифра в числе: {maxDigit}");


int MaxDigit(int num)
{
    int first = num / 10;
    int second = num % 10;
    int result = first > second ? first : second;
    return result;
}