Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод числа
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine()); // ввод числа
if (n > m)
Console.Write(n);
else if (m > n)
Console.Write(m);
else if (m == n)
Console.Write("числа равны"); 
