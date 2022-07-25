// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] matr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(start, end);
        }
    }
}

void PrintArray(int[,] matr1)
{
    for (int i=0; i<matr1.GetLength(0);  i++)
    {
        for (int j = 0; j<matr1.GetLength(1); j++)
        {
            Console.Write($"{matr1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortRawToMin(int[,] matr2)
{
  for (int i = 0; i < matr2.GetLength(0); i++)
  {
    for (int j = 0; j < matr2.GetLength(1); j++)
    {
      for (int k = 0; k < matr2.GetLength(1) - 1; k++)
      {
        if (matr2[i, k] < matr2[i, k + 1])
        {
          int tmp = matr2[i, k + 1];
          matr2[i, k + 1] = matr2[i, k];
          matr2[i, k] = tmp;
        }
      }
    }
  }
}

Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int[m, n];
FillArray(matrix, 0, 10);
PrintArray(matrix);
Console.WriteLine();
SortRawToMin(matrix);
PrintArray(matrix);