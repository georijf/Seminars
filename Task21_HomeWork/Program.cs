/* Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53
*/

Console.WriteLine("Введите координаты первой точки: ");
int xA = Convert.ToInt32(Console.ReadLine());
int yA = Convert.ToInt32(Console.ReadLine());
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int xB = Convert.ToInt32(Console.ReadLine());
int yB = Convert.ToInt32(Console.ReadLine());
int zB = Convert.ToInt32(Console.ReadLine());


double distance = GetDistance(xA, yA, zA, xB, yB, zB);

double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между указанными точками = {distanceRound}");


double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
