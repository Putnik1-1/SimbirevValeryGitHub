//  18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите число от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());

string quater = Quarter(number);

Console.Write($"Диапазон координат {quater}");

string Quarter(int numberA)
{
    if (numberA == 1) return "x > 0, y > 0";
    if (numberA == 2) return "x < 0, y > 0";
    if (numberA == 3) return "x < 0, y < 0";
    if (numberA == 4) return "x > 0, y < 0";
    return "не соответсвует номеру четверти";
}