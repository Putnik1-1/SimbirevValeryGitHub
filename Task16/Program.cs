// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool x2(int a, int b)
{
    return a == b * b || b == a * a;
}
if (x2(numberA, numberB)) Console.WriteLine($"{numberA}, квадрат {numberB}");
else Console.WriteLine($"{numberA}, не квадрат {numberB}");
