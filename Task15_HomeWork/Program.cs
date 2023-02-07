/* Задача 15: Напишите программу, которая 
принимает на вход цифру, обозначающую 
день недели, и проверяет, является 
ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введите порядковый номер дня недели, где Пн - 1; Вс - 7: ");
int NumOfWeek = Convert.ToInt32(Console.ReadLine());

if (NumOfWeek > 0 && NumOfWeek <= 5)
{
    Console.Write("Не выходные");
}

if (NumOfWeek > 5 && NumOfWeek < 8)
{
    Console.Write("Выходные ☻");
}

if (NumOfWeek < 1 || NumOfWeek > 7)
{
    Console.Write("Вы ввели не корректный порядковый номер дня недели.");
}
