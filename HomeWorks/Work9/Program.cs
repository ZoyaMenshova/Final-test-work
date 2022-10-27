// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int n, int m)
{
    if(m!=n)
    {
    if(n > m) 
    {
        ShowNumbers(n - 1, m); 
        Console.Write(n + " ");
    }    
    else
    {
        ShowNumbers(m - 1, n); 
        Console.Write(m + " ");
    }    
    }
    else
        Console.Write(m + " ");
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
ShowNumbers(a,b);
*/

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum (int n, int m)
{
    if(m != n)
    {
        if(m > n)
            return n + FindSum(n+1, m);
        else
            return m + FindSum(n, m+1);    
    } 
    else
        return m;     
}
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = FindSum(a,b);
Console.WriteLine($"The summa of all number in this branch is {sum}.");
*/
// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman( int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return Akkerman(n - 1, 1);
        else
            return Akkerman(n - 1, Akkerman(n, m - 1));        
}
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int function = Akkerman(a,b);
Console.WriteLine($"Value of Function is {function}");
*/
