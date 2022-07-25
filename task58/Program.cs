// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.


void FillArray(int[,] matr)
{
    matr[0, 0] = 1;

    for (int j = 1; j < matr.GetLength(1); j++)
    {
        int i = 0;
        matr[i, j] = matr[i, j - 1] + 1;
    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int j = 3;
        matr[i, j] = matr[i - 1, j] + 1;
    }
    for (int j = 2; j >= 0; j--)
    {
        int i = 3;
        matr[i, j] = matr[i, j + 1] + 1;
    }
    for (int i = 2; i >= 1; i--)
    {
        int j = 0;
        matr[i, j] = matr[i + 1, j] + 1;
    }
    for (int j = 1; j < matr.GetLength(1) - 1; j++)
    {
        int i = 1;
        matr[i, j] = matr[i, j - 1] + 1;
    }
    matr[2, 2] = 15;
    matr[2, 1] = 16;
}

void PrintArray(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        if (matr1[i, j]<10)
        {
            Console.Write($" {matr1[i, j]} ");
        }
        else 
        {
            Console.Write($"{matr1[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
