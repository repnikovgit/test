// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Введите число: ");

string s = Console.ReadLine();
int i;

if (int.TryParse(s, out i)) {
System.Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
}
else{
System.Console.WriteLine("Упс");
}
