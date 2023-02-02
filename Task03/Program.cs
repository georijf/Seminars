/* 3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.Write("Введите число от 1 до 7: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek == 1)
{
    Console.WriteLine("Сегодня понедельник");
}
else if (DayOfWeek == 2)
{
    Console.WriteLine("Сегодня вторик");
}
else if (DayOfWeek == 3)
{
    Console.WriteLine("Сегодня среда");
}
else if (DayOfWeek == 4)
{
    Console.WriteLine("Сегодня четверг");
}
else if (DayOfWeek == 5)
{
    Console.WriteLine("Сегодня пятница");
}
else if (DayOfWeek == 6)
{
    Console.WriteLine("Сегодня суббота");
}
else if (DayOfWeek == 7)
{
    Console.WriteLine("Сегодня воскресенье");
}
else
{
    Console.Write("Нужно ввести число от 1 до 7");
}