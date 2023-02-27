Console.Write("Введите длинну массива: ");
int array = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[array];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
