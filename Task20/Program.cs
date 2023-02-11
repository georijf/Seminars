/* Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

//Math.Pow(2, 10); Водведение числа 2 в степень 10
//Math.Sq   

/* double d = 5.099753443;
double dRound = Math.Round(d, 2, MidpointRounding.ToZero);  // количество знаков после запятой
Console.WriteLine(dRound); */

Console.WriteLine("Введите координаты первой точки: ");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());

double distance = GetDistance(xA, yA, xB, yB);

double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между указанными точками = {distanceRound}");



double GetDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}