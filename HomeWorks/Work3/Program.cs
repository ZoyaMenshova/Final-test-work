// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно полиндромом.
/*
void Polindrom(int number)
{
    int number1 = (number % 100000) / 10000;
    int number2 = (number % 10000) / 1000;
    int number4 = (number % 100) / 10;
    int number5 = number % 10;
       if (number5 == number1 && number4 == number2)
           Console.WriteLine($" This is number {number} polindrom");
       else
       Console.WriteLine($" This is number {number} not polindrom");
}
Console.Write("Input fifenumber:  ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrom (number);
*/

// Задача 2. Напищите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
/*
double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{

  return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));  
  
} 

Console.Write("Input x1:  ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1:  ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1:  ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2:  ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2:  ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z3:  ");
double zb = Convert.ToDouble(Console.ReadLine());
double coordinate = FindDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Distance is {coordinate}");
*/

// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
/*
void ShowCube(int n)
{   
    int current = 1;
    while(current <= n)
   {    
       Console.WriteLine($"Куб числа {current} = {current * current * current}");
       current++;
   }
}
Console.Write("Введите любое целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCube(number);
*/
