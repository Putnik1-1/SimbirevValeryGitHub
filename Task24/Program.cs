Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number);
Console.Write($"Сумма чисел от 1 до {number} равна {sum}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}