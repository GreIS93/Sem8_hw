// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.


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

int [,] matrix = new int[5, 3];
FillArray(matrix, 0, 10);
PrintArray(matrix);
Console.WriteLine();

int RowSum(int[,] matr2, int i)
{
  int rowsum = matr2[i,0];
  for (int j = 1; j < matr2.GetLength(1); j++)
  {
    rowsum = rowsum+matr2[i,j];
  }
  return rowsum;
}

int minsumrow = 0;
int sum = RowSum(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = RowSum(matrix, i);
  if (sum > temp)
  {
    sum = temp;
    minsumrow = i;
  }
}

Console.WriteLine($"{minsumrow+1} строкa с наименьшей суммой элементов ");
