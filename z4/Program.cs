Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод числа
for (int i = 2 ; i <= n ; i+=2 );
    Console.Write($"{i} ");
