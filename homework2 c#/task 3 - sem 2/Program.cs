/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

System.Console.WriteLine("Введите N: ");
int num = new Random().Next(10, 100000);
int num = int.Parse(Console.ReadLine());
int s;
while (s > 100 && s <1000);
System.Console.WriteLine(s%10);
while (s > 999);
System.Console.WriteLine(s/10);
if (s < 999)
{
    System.Console.WriteLine(s % 10);
}
else{
    System.Console.WriteLine(bad);
}

//if (s % 2 == 0){ // остаток от деления на 10
/*if (s >=100 && s < 1000)
{
    Console.WriteLine($"{s} -> {s%10}");
}
/*else{
    System.Console.WriteLine("bad");
}*/
/*
if (s < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
*/


//Console.WriteLine($"{num} -> {num/100}{num%10}");