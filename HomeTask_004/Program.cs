/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

// Метод формирования трехмерной матрицы
int[,,] CreateMatrix(int row, int colum, int page, int min, int max)
{
    int[,,] matrix = new int[row, colum, page];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                { 
                    matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k);
                }
        }
    }
    return matrix;
}

Random rand = new Random();
// Метод проверки и получения уникального числа в трехмерном массиве
int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    int value = 0;
    bool exist = true;
    while (exist)
    {
        bool breakOut = false;
        value = rand.Next(min, max + 1);
        for (int n = 0; n < matrix.GetLength(0); n++)
        {
            if (breakOut) { break; }
            for (int m = 0; m < matrix.GetLength(1); m++)
            {
                if (breakOut) { break; }
                for (int a = 0; a < matrix.GetLength(2); a++)
                {
                    if (matrix[n, m, a] == value) { breakOut = true; break; }
                    if (n == i && m == j && a == k) { exist = false; }
                }
            }
        }
    }
    return value;
}
void PrintTripleArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) 
            { 
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k})    "); 
            }
            Console.WriteLine();
        }
    }
}

int[,,] tripleArray = CreateMatrix(3, 3, 3, 10, 99);
PrintTripleArray(tripleArray);
