// Задача 1. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
/*
int SecondIndexNumber(int number)
{
      int dec = number / 10;
      return dec % 10;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int newNumber = SecondIndexNumber(n);
Console.WriteLine($"New version of {n} is {newNumber}");
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int Checing(int number)
{
    while (number > 1000)
       number = number / 10;
    if(number > 100)
       number = number % 10;    
    else
       Console.WriteLine($"There number no");
    return number;    
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int NewNumber = Checing(number);

Console.WriteLine($"{NewNumber}");
*/

// Задача 3. Напишите пограмму, которая принимает на вход цифру, обозначающую дни недели, и проверяет, является ли этот день выходным.
/*
void Week(int number)
{
    if (number < 6)
        Console.WriteLine($"This is Work day");
    else
        Console.WriteLine($"This is weekend");
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Week(n);
*/






