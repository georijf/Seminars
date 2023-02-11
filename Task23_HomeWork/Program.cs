/* Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число\tТаблица кубов");
SquareTable(number);

void SquareTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}\t{count * count * count}");
        count++;
    }
}
