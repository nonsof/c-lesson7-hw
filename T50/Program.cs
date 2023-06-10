// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


using System.Security.Cryptography.X509Certificates;

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

int getAPoint1 ()
{
    int m = Promt ("Введите значение первой точки");
    return m;
    
}

int getAPoint2 ()
{
    int n = Promt ("Введите значение второй точки");
    return n;
}

void PrintPoints (int getAPoint1, int getAPoint2)
{
    Console.WriteLine ($"Индекс искомого элемента; [{getAPoint1}, {getAPoint2}]");
}


void findAnElement (int [,] array, int getAPoint1, int getAPoint2)
{
    
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (0); j++)
        {
            int m = getAPoint1;
            int n = getAPoint2;
            if (m == i && n == j)
            {
                Console.WriteLine (array[i, j]);
            } 
            else if (m != i && n != j)
            {
                Console.WriteLine ("connot find an element in array");
            }
        }
    }
}



int[,] array2d = GetArray2s();
PrindArray2d(array2d);
int m = getAPoint1();
int n = getAPoint2();
PrintPoints(m, n);
findAnElement (array2d, m, n);

