/*
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first integer number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {num1}");
}
{
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {num2}");
}
*/
/*
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
Console.Write("Input first integer number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max < num2) 
{
 if (num2 < num3)
 {
    max = num3;
 }
 else
 {
    max = num2;
 }
}
else
{
   if (max > num2)
   {
    if (max < num3)
    {
        max = num3;
    }
   }
};
Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
*/
/*
//задача 3:  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
string answer = "да";
if (num%2 != 0)
{
    answer = "нет";
};
Console.WriteLine($"{num} -> {answer}");
*/
/*
//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");
int result = 2;
while (result < (num - 1))
{
    Console.Write($"{result}, ");
    result = result + 2;
};
Console.Write(result);
*/