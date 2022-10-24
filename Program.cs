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

double[,] array = FillArray(rows, columns, -10 ,10);
PrintArrayD(array);







// Заполнение массива случайными вещественными числами:
double[,] FillArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] =new Random().NextDouble() * (maxValue-minValue) + minValue;
        }
    }
    return result;
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
// Вывод массива с вещественными числами:
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