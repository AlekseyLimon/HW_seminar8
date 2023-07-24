// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }


// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             if (array[i, j] < array[i, j + 1])
//             {
//                 int temp = array[i, j + 1];
//                 array[i, j + 1] = array[i, j];
//                 array[i, j] = temp;
//             }
//         }
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// SortArray(myArray);
// Console.WriteLine("\n");
// Print2DArray(myArray);










// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }


// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int LineSum(int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             sum[i] += array[i, j];
//     }
//     int maxMinIndex = 0;
//     for (int i = 0; i < sum.Length; i++)
//         if (sum[maxMinIndex] > sum[i])
//             maxMinIndex = i;
//     Console.WriteLine($"Минимальная сумма элементов {sum[maxMinIndex]} в {maxMinIndex + 1} строке");

//     return maxMinIndex;
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// LineSum(myArray);
// Console.WriteLine($"\n ");
















// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }


// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }


// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int [,] DivMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     if (matrix1.GetLength(1) == matrix2.GetLength(0))
//     {
//         for (int i = 0; i < matrix3.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix3.GetLength(1); j++)
//             {
//                 matrix3[i, j] = 0;
//                 for (int k = 0; k < matrix1.GetLength(1); k++)
//                 {
//                     matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
//                 }
//             }
//         }
//     }return matrix3;
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] firstArray = Create2DArray(rows, columns);
// Fill2DArray(firstArray, minValue, maxValue);
// Print2DArray(firstArray);
// Console.WriteLine($"\n ");
// int[,] secondArray = Create2DArray(rows, columns);
// Fill2DArray(secondArray, minValue, maxValue);
// Print2DArray(secondArray);
// Console.WriteLine($"\n ");
// int[,] resultMatrix = DivMatrix(firstArray, secondArray);
// Print2DArray(resultMatrix);
// Console.WriteLine($"\n ");








// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArrayRandomNumber(int[,,] array, int minNumber = 10, int maxNumber = 99)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber + 1);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}
bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }
    return false;
}


int[,,] Create3DArray(int rows, int cols, int dep)
{
    return new int[rows, cols, dep];
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            Console.WriteLine();
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int depth = InputNum("Введите высоту массива: ");
int[,,] myArray = Create3DArray(rows, columns, depth);
FillArrayRandomNumber(myArray);
Print3DArray(myArray);