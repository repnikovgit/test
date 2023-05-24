/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

// int num = new Random().Next(100, 1000);

Console.Clear();
System.Console.WriteLine("Введите N: ");
int num = int.Parse(Console.ReadLine());
int num1 = num%100;
int num2 = num1/10;
if (num >=100 && num < 1000)
{
System.Console.WriteLine($"{num2}");
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}

//Console.WriteLine($"{num} -> {num%100}");