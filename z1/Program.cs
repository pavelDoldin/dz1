Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите 3-те число: ");
int v = Convert.ToInt32(Console.ReadLine()); // ввод числа
if (n >= m && n >= v) 
Console.Write(n);
else if (m >= n && m >= v)
Console.Write(m);
else if (v >= n && v >= m)
Console.Write(v);