// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input number:  ");
        newArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
          Console.Write(array[i]+ " ");
    Console.WriteLine();      
}
int CountPosNumber(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if (array[i]> 0) count++;
    return count;    
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
int result = CountPosNumber(myArray);
Console.WriteLine($"Count positive numbers array is {result}");
*/

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void PointIntersec(double a, double b, double c, double d)
{

  double x = -(a - c) / (b - d);
  double y = d * x + c;
  Console.Write($"Point of intersection of two lines ({x} : {y})");
  
} 

Console.Write("Input b1:  ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1:  ");
double k = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2:  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2:  ");
double k1 = Convert.ToDouble(Console.ReadLine());
if(b==b1)
Console.WriteLine($"The lines are parallel");
else
PointIntersec(b,k,b1,k1);
*/