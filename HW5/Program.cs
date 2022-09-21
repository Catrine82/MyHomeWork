/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateArray(int size)
{
    int[] newarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newarray[i] = new Random().Next(99,1000);
    }
    return newarray;
}

int EvenNumber (int[] arr)
{   int count = 0;
   for (int i = 0; i < arr.Length; i++)
   {
        if (arr[i] % 2 == 0) count++;
   } 
   return count;
}

void PrintArray(int[] arr)
{
     
    Console.Write("[");
     for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    };
    Console.Write($"\b\b]");
}

Console.Write("Insert the size of the array: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arra = CreateArray(x);
Console.WriteLine();
PrintArray(arra);
Console.WriteLine($" -> {EvenNumber(arra)}");
*/
/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray(int size)
{
    int[] newarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newarray[i] = new Random().Next(-10,10);
    }
    return newarray;
}
void PrintArray(int[] arr)
{
     
    Console.Write("[");
     for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    };
    Console.Write($"\b\b]");
}
int EvenNumber (int[] arr)
{   int count = 0;
   for (int i = 1; i < arr.Length; i = i + 2)
   {
        count = count + arr[i];
   } 
   return count;
}
Console.Write("Insert the size of the array: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arra = CreateArray(x);
Console.WriteLine();
PrintArray(arra);
Console.WriteLine($" -> {EvenNumber(arra)}");
*/
/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] CreateArray(int size)
{
    int[] newarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newarray[i] = new Random().Next(-10,10);
    }
    return newarray;
}
void PrintArray(int[] arr)
{
     
    Console.Write("[");
     for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    };
    Console.Write($"\b\b]");
}
int MaxMin (int[] arr)
{  
    int max = arr[0];
    int min = arr[0];
   for (int i = 0; i < arr.Length; i++)
   {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
   } 
   return max - min;
}
Console.Write("Insert the size of the array: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arra = CreateArray(x);
Console.WriteLine();
PrintArray(arra);
Console.WriteLine($" -> {MaxMin(arra)}");
*/