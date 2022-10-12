// Задача 1. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
/*
int FindDegree(int numberA, int numberB)
{
 int result = 1;
 for(int i = 1; i <= numberB; i++)
    result = result * numberA;
 return result;
}

 Console.Write("Input number A: ");
 int numberA = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input number B: ");
 int numberB = Convert.ToInt32(Console.ReadLine());

 int Newnumber = FindDegree(numberA, numberB);
 Console.WriteLine($"Result {Newnumber}");
 */



// Задача 2. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
/*

int SumNumber(int number)
{
    int sum = 0;
    int dec = 0;

    for (int i = 0; i < number; i++)
    {
      dec = number - number % 10;
      sum = sum + (number - dec);
      number = number / 10;
    }
   return sum;
  }
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
      Console.Write($"Input element array at index {i}: ");
      newArray[i]=Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Array:  ");
    for(int i = 0; i < array.Length; i++)
          Console.Write(array[i]+ " ");
    Console.WriteLine();      
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
*/
