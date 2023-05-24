/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
while (numberDayOfWeek < 1 || numberDayOfWeek > 7) 
{
    Console.WriteLine("Введен неправильный номер");
    Console.Write("Введите номер для недели: ");
    numberDayOfWeek = int.Parse(Console.ReadLine());
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
else if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
else if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Это не выходной день");
}
else if (numberDayOfWeek == 2)
{
    Console.WriteLine("Это не выходной день");
}
else if (numberDayOfWeek == 3)
{
    Console.WriteLine("Это не выходной день");
}
else if (numberDayOfWeek == 4)
{
    Console.WriteLine("Это не выходной день");
}
else if (numberDayOfWeek == 5)
{
    Console.WriteLine("Это не выходной день");
}
else if (numberDayOfWeek == 6)
{
    Console.WriteLine("Это выходной");
}
else if (numberDayOfWeek == 7)
{
    Console.WriteLine("Это выходной");
}

/*
if (numberDayOfWeek == 6 || numberDayOfWeek == 7){
Console.WriteLine($"{numberDayOfWeek} -Это выходной день");
}
else
{
Console.WriteLine("Это рабочий день");
}
*/