// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.


void Homework8_54()
{
    int line = 3;
    int column = 4;
    int [,] array = new int [line, column];

    CreatArray(array);
    PrintArray(array);
    Console.WriteLine();
    Sort(array);
}

void CreatArray(int [,] SomeArray)
   {
        Random rand = new Random();
        for (int i = 0; i < SomeArray.GetLength(0); i++)
        {
            for (int j = 0; j < SomeArray.GetLength(1); j++)
            {   
                SomeArray[i,j] = rand.Next(1,10);
            }
        }
   }

void PrintArray(int [,] SomeArray)
   {
        Console.WriteLine();
        Console.WriteLine("Вывод массива на экран:");
        for(int i = 0; i < SomeArray.GetLength(0); i++)
        {
            for(int j = 0; j < SomeArray.GetLength(1); j++)
            {
                Console.Write($"{SomeArray[i, j]} \t");
            }
            Console.WriteLine();
        }
   }

void Sort(int [,] SortArray)
{
    for (int i = 0; i < SortArray.GetLength(0); i++)
    {
        for (int j = 0; j < SortArray.GetLength(1); j++)
        {
            for (int m = SortArray.GetLength(1) - 1; m > j; m--)
            {
                if (SortArray[i,m] > SortArray[i, m-1])
                {
                    int temp = SortArray[i,m];
                    SortArray[i,m] = SortArray[i, m-1];
                    SortArray[i, m-1] = temp;
                }
            }
        }
    }    
    Console.WriteLine("Отсортированный по убыванию массив:");
    PrintArray(SortArray);
}    

   //Homework8_54();

   // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
   //которая будет находить строку с наименьшей суммой элементов.


void Homework8_56()
{

    int line = 3;
    int column = 4;
    int [,] array = new int [line, column];

    CreatArray(array);
    PrintArray(array);
    Console.WriteLine();
    MinSum(array);
}

void MinSum(int [,] SomeArray)
{
    int MinSumLine = 0;
    int IndexMinSumLine = 0;

    for (int j = 0; j < SomeArray.GetLength(1); j++)
    {
        MinSumLine += SomeArray[0,j];
    }

    for (int i = 0; i < SomeArray.GetLength(0); i++)
    {
        int SumLine = 0;
        for (int j = 0; j < SomeArray.GetLength(1); j++)
        {
            SumLine += SomeArray[i,j];
        }

        Console.WriteLine($"Сумма элементов {i} строки: {SumLine}");
        if (SumLine < MinSumLine)
        {
            MinSumLine = SumLine;
            IndexMinSumLine = i;
        }
        
    }
    Console.WriteLine($"Среди всех строк наименьшая сумма элементов в строке {IndexMinSumLine}. Она составляет {MinSumLine}");
}

//Homework8_56();

// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

//В голове не укладывается, буду смотреть решение с вами :)

