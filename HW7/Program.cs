
/*
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArray()
{    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    double[,] newArray = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++) 
        {
            double y = new Random().NextDouble();
            double z = new Random().Next(-10, 10);
            newArray[i,j] = Math.Round(y,2) + z;
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j  = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]}| ");
        Console.Write($"\b\b ");
        Console.WriteLine();
    }
     Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j  = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]}| ");
        Console.Write($"\b\b ");
        Console.WriteLine();
    }
     Console.WriteLine();
}

int [,] CreateRandom2dArray()
{    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++) 
        {
            newArray[i,j] = new Random().Next(-10, 10);             
        }
    }
    return newArray;
}

void FindPosition(int[,] array)
{
    Console.Write("Enter position in row: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter position in colum: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    if (rows <= array.GetLength(0) || (colums <= array.GetLength(1)))
    {
        Console.WriteLine($"{rows}, {colums} -> {array[rows-1, colums-1]}");
    } 
    else
    {
        Console.WriteLine($"{rows}, {colums} -> такого числа в массиве нет");
    }
}

int[,] MyArray = CreateRandom2dArray();
Show2dArray(MyArray);
FindPosition(MyArray);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateRandom2dArray()
{    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++) 
        {
            newArray[i,j] = new Random().Next(-10, 10);             
        }
    }
    return newArray;
}

void Mean(int [,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j <= array.GetLength(1); j++)
        {
            sum = sum + Convert.ToDouble(array[i,j]);
        }
        sum = sum/Convert.ToDouble(array.GetLength(1)+1);
        Console.Write($"{sum}, ");
    }
    Console.Write($"\b\b ");
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j  = 0; j < array.GetLength(1); j++) Console.Write($"{array[i,j]}| ");
        Console.Write($"\b\b ");
        Console.WriteLine();
    }
     Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray();
Show2dArray(MyArray);
Mean(MyArray);