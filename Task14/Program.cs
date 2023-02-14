// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введи число:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 7;
int num2 = 23;

bool Multiplicity(int number, int number1, int number2)
{
    return number % number1 == 0 && number % number2 == 0;
}

if (Multiplicity(num, num1, num2))
    Console.WriteLine($"Введенное число {num} кратно {num1} и {num2}");
else Console.WriteLine($"Введенное число {num} не кратно {num1} и {num2}");

