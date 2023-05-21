/* Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое квадратом второго */

System.Console.WriteLine("Введите первое число: ");
System.Console.WriteLine("Введите второе число: ");
string s = Console.ReadLine();
string d = Console.ReadLine();
int i = int.Parse(s);
int j = int.Parse(d);

if (i == Math.Pow(j,2)){
    System.Console.WriteLine("good");
}
else{
    System.Console.WriteLine("bad");
}