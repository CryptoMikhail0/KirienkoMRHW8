// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            array[i,j] = random.Next(0, 5);
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

int [,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return result;
}

bool MatrixInteroperability(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int rows1 = InputNum("Введите количество строк в первой матрице: ");
int columns1 = InputNum("Введите количество столбцов в первой матрице: ");
int rows2 = InputNum("Введите количество строк во второй матрице: ");
int columns2 = InputNum("Введите количество столбцов во второй матрице: ");

int[,] matrix1 = Create2DArray(rows1, columns1);
FillArray(matrix1);
Print2DArray(matrix1);
System.Console.WriteLine();

int[,] matrix2 = Create2DArray(rows2, columns2);
FillArray(matrix2);
Print2DArray(matrix2);
System.Console.WriteLine();

bool interoperability = MatrixInteroperability(matrix1, matrix2);

if (interoperability == true)
{
    int [,] multiplication = MatrixMultiplication(matrix1, matrix2);
    Print2DArray(multiplication);
}
else
    System.Console.WriteLine("Матрицы несовместимы");