﻿Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите 3-те число: ");
int v = Convert.ToInt32(Console.ReadLine()); // ввод числа
if (n > m )
Console.Write(n);
else if (m > n)
Console.Write(m);
else if (v > n)
Console.Write(v);
else if (v > m)
Console.Write(v);
else (m > v)
Console.Write(m);