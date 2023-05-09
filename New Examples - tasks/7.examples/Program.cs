int random = new Random().Next(100,1000);
Console.WriteLine(random);

int first = random / 100;
int second = random % 10;

if (first > second);
{ 
    Console.Write(first);
};
else
{
     Console.Write(second);
}

// Console.WriteLine($"{first}{second}");