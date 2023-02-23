// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 9999 && number < 100000)
// {
//     if(Polydrome(number)) Console.Write($"Данное число: {number} полиндром");
//     else Console.Write($"Данное число: {number} не полиндром");
// }
// else
// {
//     Console.Write("Вы ввели не пятизначное число");
// }

// bool Polydrome(int num)
// {
//     int num1 = num % 10;
//     int num2 = num / 10 % 10;
//     int num3 = num / 100 % 10;
//     int num4 = num / 1000 % 10;
//     int num5 = num / 10000;
//     int newNumber = num1 * 10000 + num2 * 1000 + num3 * 100 + num4 * 10 + num5;
//     if(num1 == num5 && num2 == num4) return true;
//     else return false;
// }


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(Polydrome(number)) Console.Write($"Данное число: {number} полиндром");
else Console.Write($"Данное число: {number} не полиндром");

bool Polydrome(int num)
{
    int numA = 0;
    int newNumber = num;
    while (num > 0)
    {
        numA = numA * 10 + num % 10;// num= numA = 3 numA = 32 numA = 321
        num = num / 10;
    }
    if(numA == newNumber) return true;
    else return false;
}