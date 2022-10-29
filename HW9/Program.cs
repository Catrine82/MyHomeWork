/*
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void Nat(int m, int n)
{
    Console.Write($"{Math.Min(m,n)} ");
    if (Math.Min(m,n) < Math.Max(m,n))
    {
        Nat(Math.Min(m,n)+1,Math.Max(m,n));
    }
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Nat(m,n);
*/
/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int Nat(int m, int n)
{
    if (m == n)
        return m;
    else
    if (Math.Min(m,n) < Math.Max(m,n))
        return Nat(Math.Min(m,n)+1,Math.Max(m,n)) + Math.Min(m,n);
        else return 0;
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {m}, N = {n} -> {Nat(m,n)}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
double Nat(double m, double n)
{
    if (m < 2) return n + m + 1;
    else
    if (m == 2) return 2*n + 3;
    else
    if (m == 3) return Math.Pow(2,n+3)-3;
    return Math.Pow(2,Nat(m-1,n)+3)-3;   
    
}

Console.Write("Input M: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Input N: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.Write($"M = {m}, N = {n} -> {Nat(m,n)}");
