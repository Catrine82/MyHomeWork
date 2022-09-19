/*
//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Pallindrom(int num)
{
    int beg = 1;
    string numtext = Convert.ToString(num);
    int end = numtext.Length;
    int digit = num;
    int stepen = Convert.ToInt32(Math.Pow(10,numtext.Length-1));
    bool result = true;
    while (beg < end)
    {
        if (digit/stepen != (digit%10))
        {
            result = false;
            break;
        };
        digit = ((digit%stepen)/10);
        beg = beg + 1;
        end = end - 1;
        stepen = Convert.ToInt32(Math.Pow(10,end-beg));
    }
    return result;
}
Console.Write("Insert any number: ");
int nums = Convert.ToInt32(Console.ReadLine());
if (Pallindrom(nums) == true)
{
    Console.WriteLine($"{nums} -> да");
}
else
{
    Console.WriteLine($"{nums} -> нет");
}
*/
/*
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double LengthSegment(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb));
}
Console.Write("Insert x first point: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert y first point: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert z first point: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert x second point: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert y second point: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Insert z sevond point: ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"A({xa},{ya},{za}); B({xb},{yb},{zb}) -> {Math.Round(LengthSegment(xa,ya,za,xb,yb,zb),2)}");
*/
/*
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void kub(int num)
{
    int i = 1;
    Console.Write($"{num} -> 1");
    do
    {
        i++;
        Console.Write($", {i*i*i}");
    } while (i<num);
}
Console.WriteLine("Insert any positive number: ");
kub(Convert.ToInt32(Console.ReadLine()));
*/
