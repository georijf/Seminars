/* Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник со сторонами
такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

bool TriangleCheck(int a, int b, int c)
{
    return a < b + a && b < a + c && c < a + b;
}

Console.WriteLine("Введите три стороны треугольника:");
Console.Write("Введите сторону a: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool res = TriangleCheck(sideA, sideB, sideC);
Console.WriteLine(res ? "Да" : "Нет");