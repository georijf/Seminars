/* 17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка. */

Console.Write("Введите координату точки по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0
                        ? $"Указанные координаты соотвествуют четверти: {quarter}"
                        : "Введены некорректные координаты";

Console.WriteLine(result);

int Quarter(int positionX, int positionY)
{
    if (positionX > 0 && positionY > 0) return 1;
    if (positionX < 0 && positionY > 0) return 2;
    if (positionX < 0 && positionY < 0) return 3;
    if (positionX > 0 && positionY < 0) return 4;
    return 0;
}












/* if (positionX > 0 && positionY > 0)
{
    Console.Write("Координата указанных точек находится четверти №1");
}
if (positionX < 0 && positionY > 0)
{
    Console.Write("Координата указанных точек находится четверти №2");
}
if (positionX < 0 && positionY < 0)
{
    Console.Write("Координата указанных точек находится четверти №3");
}
if (positionX > 0 && positionY < 0)
{
    Console.Write("Координата указанных точек находится четверти №4");
}
else
{
    Console.WriteLine("Вы ввели не корректные координаты");
} */
