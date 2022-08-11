/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"{n1} is max {n2} is min");
}
else
{
     Console.WriteLine($"{n1} is min  {n2} is max");
}
*/

/*
// Задача 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (n2 >max) 
{
    max = n2;
}
if (n3 >max)
{
    max = n3;
}    
    Console.WriteLine($"max is {max}");
*/

/*
// Задача 3. напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} is even number");
}
else
{
     Console.WriteLine($"{number} is not even number");
}
*/

/*
// Задача 4. Напишите программу, которая на вход принимает число(N), а на выходе показывает все четные числа от 1 до N

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int current = 1; current <= number; current ++ )
     if(current % 2 == 0)
     {
        Console.WriteLine($"{current} is even number");
     }
*/

