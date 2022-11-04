/*************************************************************************************************
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*************************************************************************************************/

// Console.WriteLine("Ведите количество строк массива");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Ведите количество столбцов массива");
// int columns = int.Parse(Console.ReadLine()!);

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

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Average(array);

/*************************************************************************************************
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*************************************************************************************************/

// Console.Write("Ведите длину массива: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите высоту массива: ");
// int y = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите ширину массива: ");
// int z = int.Parse(Console.ReadLine()!);

// int[, ,] array = GetArray3(x, y, z, 10, 99);
// PrintArray3(array);

/*************************************************************************************************
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*************************************************************************************************/

Console.WriteLine("Ведите количество строк массива");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите количество столбцов массива");
int columns = int.Parse(Console.ReadLine()!);

int[,] arraySpiral = FillArraySpiral(GetArrayNull(rows, columns));
PrintArray(arraySpiral);


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
// Заполнение двумерного массива случайными целыми числами:
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
// Заполнение двумерного массива нулями:
int[,] GetArrayNull(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = 0;
        }
    }
    return result;
}
// Заполнение двумерного массива спирально:
int[,] FillArraySpiral(int[,] Array)
{

int[,] result = new int[Array.GetLength(0), Array.GetLength(1)];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= result.GetLength(0) * result.GetLength(1))
{
  result[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < result.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= result.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > result.GetLength(1) - 1)
    j--;
  else
    i--;
}
return result;
}
        // Заполнение трехмерного массива случайными целыми числами:
    int[,,] GetArray3(int m, int n, int o, int minValue, int maxValue)
    {
        int[,,] result = new int[m, n, o];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < o; k++)
                {
                    result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                }
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
                if(Array[i, j] < 10){
                   Console.Write($"0{Array[i, j]} "); 
                }
                else{
                Console.Write($"{Array[i, j]} ");
                }
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
    // Вывод трехмерного массива:
    void PrintArray3(int[,,] Array)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                for (int k = 0; k < Array.GetLength(2); k++)
                {
                    Console.Write($"{Array[i, j, k]} ({i}, {j}, {k}) ");
                }
                Console.WriteLine();
            }
        }
    }