/*
//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int FindSecondDigit (int number)
{
    int result = (number - (number/100)*100)/10;
    return result;
};

Console.Write("Insert a number with three digits: ");
int num = Convert.ToInt32(Console.ReadLine());
int threedigit = FindSecondDigit(num);

Console.WriteLine($"{num} -> {threedigit}");
*/
/*
//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThreePosition (int number)
{
    int result = number;
    if ((result/100) == 0)
    {
        result = -1;
        return result;
    }
    else
    {
        while (result >= 1000)
        {
            result = result/10;
        }
    };
    result = result - (result/10)*10;
    return result;
}
Console.Write("Insert any positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num3 = ThreePosition(num);
if (num3 == -1)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{num} -> {num3}");
};
*/
/*
//Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
string Wks(int day)
{
    if (day < 0)
    {
        return "не соответствует порядковому номеру дня недели";
    }
    else
    {
        if (day > 7)
        {
            return "не соответствует порядковому номеру дня недели";
        }
        else
        {
            if (day < 6)
            {
                return "нет";
            }
            else
            {
                return "да";
            }
        }
    };
}
Console.Write("Insert any number: ");
int num = Convert.ToInt32(Console.ReadLine());
string answer = Wks(num);
Console.WriteLine($"{num} -> {answer}");
*/