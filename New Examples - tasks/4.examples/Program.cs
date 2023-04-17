/* Напишите программу,которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

/*
System.Console.WriteLine("Введите число: ");
int i = int.Parse (Console.ReadLine());
switch(i){
case 1:{
System.Console.WriteLine("Понедельник");
break;
}
case 2:{
System.Console.WriteLine("вторник");
break;
}
case 3:{
System.Console.WriteLine("среда");
break;
}
case 4:{
System.Console.WriteLine("четверг");
break;
}
case 5:{
System.Console.WriteLine("пятница");
break;
}
case 6:{
System.Console.WriteLine("суббота");
break;
}
case 7:{
System.Console.WriteLine("воскресенье");
break;
}
}
*/

Console.Write("введите число: ");
string s = Console.ReadLine();
int i = int.Parse(s);
if ( i == 1 ){
System.Console.WriteLine("Понедельник");
}
else if ( i == 2 ){
System.Console.WriteLine("Вторник");
}
else if ( i == 3 ){
System.Console.WriteLine("Среда");
}
else if ( i == 4 ){
System.Console.WriteLine("Четверг");
}
else if ( i == 5 ){
System.Console.WriteLine("Пятница");
}
else if ( i == 6 ){
System.Console.WriteLine("Суббота");
}
else if ( i == 7 ){
System.Console.WriteLine("Воскресенье");
}

else{ System.Console.WriteLine("упс");}