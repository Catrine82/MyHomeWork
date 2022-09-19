/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int x, int y)
{
    int result = 1;
    for (int count = 1; count <= y; count++)
    {
        result = result * x;
    };
    return result;
}
Console.Write("Insert natural number 1: ");
int xx = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert natural number 2: ");
int yy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{xx}, {yy} -> {Stepen(xx,yy)}");
*/
/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int DigitSum(int num)
{
    string number = Convert.ToString(num);
    int count = number.Length;
    //int number = Convert.ToInt32(num);
    int step = Convert.ToInt32(Math.Pow(10,count-1));
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        result = result + num/step;
        num = num%step;
        step = step/10;
    }
    return result;
}
Console.Write("Insert natural number: ");
int text = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{text} -> {DigitSum(text)}");
*/
/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void CreatePrintArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(1,10);
        Console.Write($"{arr[i]}, ");
    };
    Console.Write($"\b\b -> [");
     for (int i = 0; i < 8; i++)
    {
        Console.Write($"{arr[i]}, ");
    };
    Console.Write($"\b\b]");
}
CreatePrintArray();
*/