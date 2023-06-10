// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Promt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetArray2s ()
{
    int m = Promt ("Введите значение m");
    int n = Promt ("Введите значение n");
    int [,] array = new int [m, n];
    for (int i = 0; i < m; i ++) // переходы по строчкам
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random(). Next (1, 10);
        }
    }

    return array;
}

void PrindArray2d (int [,] array2d)
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

int[,] array2d = GetArray2s();
PrindArray2d(array2d);

Console.WriteLine("---------------------------");

for (int j = 0; j < array2d.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        sum += array2d[i, j];
    }
    Console.Write($"{sum/ array2d.GetLength(0)}" );
    Console.WriteLine();
}
