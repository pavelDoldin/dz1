Console.Clear();
Console.WriteLine("Введите любое число: "); // ввод числа
string numberStr = Console.ReadLine() ??""; 
int number = int.Parse(numberStr); 
for(int i = 2; i <= number; i = i + 2) 
{ 
    Console.Write($"{i}, "); 
}