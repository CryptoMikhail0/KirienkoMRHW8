/*  Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArrayBySpiral(int[,] array)
{
    int count = 1;
    int circleCount = 0;
    array[0,0] = 0;
    while (count <= array.Length)
    {
        for (int j = circleCount; j < array.GetLength(1) - circleCount; j++)
        {
            array[circleCount,j] = count;
            count++;
        }
        for (int i = circleCount + 1; i < array.GetLength(0) - (circleCount + 1); i++)
        {
            array[i, array.GetLength(1) - circleCount - 1] = count;
            count++;
        }
        for (int j = array.GetLength(1) - (circleCount + 1); j >= circleCount; j--)
        {
            array[array.GetLength(0) - circleCount - 1,j] = count;
            count++;
        }
        for (int i = array.GetLength(0) - (circleCount + 2); i >= circleCount + 1; i--)
        {
            array[i,circleCount] = count;
            count++;
        }
        circleCount++;

    }
    if (array.Length % 2 == 1)
        array[array.GetLength(0) / 2, array.GetLength(0) / 2] = array.Length;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
                Console.Write($"0{array[i,j]}\t");
            else
                Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int rows = InputNum("Введите размер квадратного массива: ");

int[,] matrix = Create2DArray(rows, rows);
FillArrayBySpiral(matrix);
Print2DArray(matrix);
