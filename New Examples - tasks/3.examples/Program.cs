/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
a = 25, b = 5 ->да
a = 2, b= 10 -> нет
*/

/*
Console.Write("Введите число: ");

string s = Console.ReadLine();
int i;

if (int.TryParse(s, out i)) {
System.Console.WriteLine($"Квадрат числа {i} = {Math.Pow(i, 2)}");
}
else{
System.Console.WriteLine("Упс");
}
*/

Console.WriteLine("Введите первое число (a):");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число (b):");
int b = int.Parse(Console.ReadLine());

if (a == b * b) {
Console.WriteLine("Да");
} else {
Console.WriteLine("Нет");
}