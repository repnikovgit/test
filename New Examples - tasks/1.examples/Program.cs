/*
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
    collection[index] = new Random().Next(1,10);
    index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
*/

// new int[10] // создай новый массив в котором будет 10 элементов
// void // не возвращает значения

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
    collection[index] = new Random().Next(1,10);
    index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если числа не будет, то будет показываться -1
    while (index < count)
    {
       if(collection[index] == find)
       {
        position = index;
       }
       index++;
    }
    return position;
}    

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = index0f(array, 4);
Console.WriteLine(pos);

