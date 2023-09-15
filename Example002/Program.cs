/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
         for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(0, 10);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindRowSum(int[,] array)
{
    int[] rowSum = new int[array.GetLength(0)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum[count] += array[i,j];
        }
        count++;
    }
    return rowSum;
}

void FinMinEl(int[] array)
{
    int min = array[0];
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min = array[i];
            count = i;
        }

    }
    count += 1;
    Console.WriteLine("Строка с минимальной суммой эл-ов(" + min + "): " + count);
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] matrix = Create2DArray(rows, columns);
FillArray(matrix);
Print2DArray(matrix);
int[] sumInRows = FindRowSum(matrix);
System.Console.WriteLine();
FinMinEl(sumInRows);