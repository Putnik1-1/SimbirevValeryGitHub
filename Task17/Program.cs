// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Write("Введите координаты точки x: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quater = Quarter(xc, yc);
string result = quater > 0 
                ? $"Указанные координаты соответсвуют четверти {quater}"
                : "Введены некоректные координаты";
Console.Write(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}