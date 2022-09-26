/*
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void PrintArray(int[] arr)
{
     
    Console.Write("[");
     for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    };
    Console.Write($"\b\b]");
}
int PositiveNumber (int[] arr)
{   int count = 0;
   for (int i = 0; i < arr.Length; i++)
   {
        if (arr[i] < 0) count++;
   } 
   return count;
}

Console.Write("Insert the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Insert {i+1} number: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
};
PrintArray(arr);
Console.Write($" -> {PositiveNumber(arr)}");
*/
/*
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
double[] Function (double b1, double k1, double b2, double k2)
{
    double[] arr = new double[2];
    arr[0] = (b2-b1)/(k1-k2);
    arr[1] = k1*arr[0]+b1;
    return arr;
}
Console.Write("Insert b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double[] answer = Function(b1,k1,b2,k2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({answer[0]}; {answer[1]})");
*/