/* 
Напишите программу, которая принимает на вход трехзначное число,
 и на выходе показывает последнюю цифру этого числа.
456->6
782->2
918->8
*/

System.Console.WriteLine("Введите N: ");

int s = int.Parse(Console.ReadLine());

if (s >=100 && s < 1000)

{

System.Console.WriteLine(s % 10); // остаток от деления на 10

}

else{

System.Console.WriteLine("это не 3зн число");

}
