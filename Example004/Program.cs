/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray()
{
    int[] newArr = new int[90];
    return newArr;
}

void FillArray(int[] arr)
{
    arr[0] = 10;
    for (int i = 1; i < arr.Length; i++)
        arr[i] = arr[i - 1] + 1;
}

int[,,] Create3DArray(int rows, int columns, int deep)
{
    return new int[rows, columns, deep];
}

void Fill3DArray(int[,,] array, int[] arr)
{
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (l % 2 == 0)
                    array[i,j,k] = arr[l];
                else
                    array[i,j,k] = arr[arr.GetLength(0) - l];
                l++;
            }
         } 
    } 
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Слой {i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();        
        }
    }
}


int rows = InputNum("Введите первое измерение массива: ");
int columns = InputNum("Введите второе измерение массива: ");
int deep = InputNum("Введите третье измерение массива: ");

int[] arr = CreateArray();
FillArray(arr);

if (rows * columns * deep <= 90)
{
    int[,,] matrix = Create3DArray(rows, columns, deep);
    Fill3DArray(matrix, arr);
    Print3DArray(matrix);
}
else
{
    System.Console.WriteLine("Превышены размеры массива");
}