/* Задача 29: 
Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

Console.WriteLine("Длинну массива: ");
int VstArray = Convert.ToInt32(Console.ReadLine()); ;

int[] randomArray = new int[VstArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i] + " ");
}
