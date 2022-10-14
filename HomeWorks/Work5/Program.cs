//Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
       newArray[i] = new Random().Next(100,1000);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
          Console.Write(array[i]+ " ");
    Console.WriteLine();      
}
int CountElements(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if (array[i]%2==0) count++;
    return count;    
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
int result = CountElements(myArray);
Console.WriteLine($"Number of even numbers in the array {result}");
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
       newArray[i] = new Random().Next(-100,100);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
          Console.Write(array[i]+ " ");
    Console.WriteLine();      
}
int SumElements(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
            if (i%2 > 0) sum = sum + array[i];
    return sum;    
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
int result = SumElements(myArray);
Console.WriteLine($" Sum of elements standing on odd positions {result}");
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*

double[] CreateRandomArray(int size, double maxsize)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
       newArray[i] = new Random().NextDouble()*maxsize;

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
          Console.Write(array[i]+ " ");
    Console.WriteLine();      
}
void FindMaxMinDiff(double[] array)

{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
    }
Console.WriteLine($"Difference between maximal and minimal array elements is {max - min}");
}            
                                                             
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max Value: ");
double max = Convert.ToDouble(Console.ReadLine());
double[] myArray = CreateRandomArray(a, max);
ShowArray(myArray);
FindMaxMinDiff(myArray);
*/