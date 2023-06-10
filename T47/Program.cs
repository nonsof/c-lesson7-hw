// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Promt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] GetAnArray2d ()
{
    int m = Promt ("Введите значение m");
    int n = Promt ("Введите значение n");
    double [,] array = new double [m, n];
    for (int i = 0; i < m; i ++) // переходы по строчкам
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random(). NextDouble () *100;
        }
    }

    return array;
}

void PrindArray2d (double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray2dSimple (double [,] array2d)
{
      for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d [i, j] = Math.Round (array2d [i, j], 2);
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double [,] array2d = GetAnArray2d();
Console.WriteLine();
PrindArray2d(array2d);
Console.WriteLine();
PrintArray2dSimple (array2d);

