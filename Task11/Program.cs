int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное трехзначное число: {number}");

int CutNum = Cut(number);
Console.WriteLine($"Цифра из первого и последнего числа трехначной цифры: {CutNum}");

int Cut(int num)
{
    int first = num / 100;
    int last = num % 10;
    int result = first * 10 + last;
    return result;
}