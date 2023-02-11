/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */




Console.Write("Введите номер четверти сисемы координат: ");
string quarter = Console.ReadLine();

string result = RangeCoordinates(quarter);
Console.WriteLine(result);

string RangeCoordinates(string coords)
{
    if (coords == "1") return "Допустимые знаения координат в этой четверти: x > 0, y > 0";
    if (coords == "2") return "Допустимые знаения координат в этой четверти: x < 0, y > 0";
    if (coords == "3") return "Допустимые знаения координат в этой четверти: x < 0, y < 0";
    if (coords == "4") return "Допустимые знаения координат в этой четверти: x > 0, y < 0";
    return "В системе координат нет такой четверти";
}
