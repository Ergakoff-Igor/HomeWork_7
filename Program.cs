/*************************************************************************************************
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*************************************************************************************************/

Console.WriteLine("Ведите количество строк массива");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите количество столбцов массива");
int columns = int.Parse(Console.ReadLine()!);

// double[,] array = FillArray(rows, columns, -10, 10);
// PrintArrayD(array);

/*************************************************************************************************
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2
*************************************************************************************************/

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.Write("Ведите номер позиции в строке: ");
// int IndexI = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите номер позиции в столбце: ");
// int IndexJ = int.Parse(Console.ReadLine()!);
// OutputIndex(array, IndexI, IndexJ);

/*************************************************************************************************
Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*************************************************************************************************/

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Average(array);



// Заполнение массива случайными вещественными числами:
double[,] FillArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}
// Метод нахождения элемента двумерного массива:
void OutputIndex(int[,] arr, int roWIndex, int colIndex)
{
    if (roWIndex > arr.GetLength(0) || colIndex > arr.GetLength(1))
    {
        Console.WriteLine($"Позиции [{roWIndex}, {colIndex}] нет в массиве");
    }
    else
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (roWIndex == i && colIndex == j)
                {
                    Console.WriteLine($"Элемент, находящийся на позиции [{roWIndex}, {colIndex}] - {arr[i, j]}");
                    break;
                }

            }
        }
    }
}
// Метод нахождения среднего арифметического в каждом столбце массива:
void Average(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"Среднее арифметическое по столбцам: {sum / arr.GetLength(0):f1}; ");
    }

}

// Заполнение массива:
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
// Вывод двумерного массива:
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Вывод двумерного массива с вещественными числами:
void PrintArrayD(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}