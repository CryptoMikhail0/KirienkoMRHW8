/* Задайте двумерный массив, напишите программу, которая упорядочит по убыванию эллементы каждой строки двумерного массива*/

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

void SortInRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                    {
                        temp = array[i,j];
                        array[i,j] = array[i,k];
                        array[i,k] = temp;
                    }
            }
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] matrix = Create2DArray(rows, columns);
FillArray(matrix);
Print2DArray(matrix);
SortInRows(matrix);
System.Console.WriteLine();
Print2DArray(matrix);