﻿Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.Write("Понедельник");
else if (day == 2) Console.Write("Вторник");
else if (day == 3) Console.Write("Среда");
else if (day == 4) Console.Write("Четверг");
else if (day == 5) Console.Write("Пятница");
else if (day == 6) Console.Write("Суббота");
else if (day == 7) Console.Write("Воскресение");
else Console.Write("Нет такого дня недели");
