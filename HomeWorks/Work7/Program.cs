// Задача 1. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
/*
double[,]CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows,columns];

    for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
       newArray[i,j] = new Random().NextDouble()*10;
    return newArray;   
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }        
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,]CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
       newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;   
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }        
}
void SearchElementsInPosition(int m, int n, int[,] array)
{
    string currentvalue;
    if(m > array.GetLength(0) || n > array.GetLength(1))
        Console.WriteLine($"There is no element with such a position");
    else 
    {
        currentvalue = Convert.ToString(array[m - 1, n - 1]);
        Console.WriteLine($"At the position {m},{n} is a number {currentvalue}");
    }   
}        

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.Write("Input number of rows element: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number columns element: ");
int y = Convert.ToInt32(Console.ReadLine());
SearchElementsInPosition(x, y, myArray);
*/

// задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,]CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
      for(int j = 0; j < columns; j++)
       newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    return newArray;   
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }        
}
void AvgColumn(int[,] array2d)
{
  for(int j = 0; j < array2d.GetLength(1); j++)
  {
    double sum = 0;
    double avg = 0;
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
       sum += array2d[i,j];
       avg = Math.Round(sum / array2d.GetLength(0), 1);
    }     
    Console.Write(avg + " ");
   }    
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
AvgColumn(myArray);
*/