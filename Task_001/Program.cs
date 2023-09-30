/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

// Метод создания двумерного массива с рандомными числами
int[,] ArrayGenerator (int m, int n, int min, int max)
{
int[,] result = new int [m, n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        result[i, j] = rand.Next(min, max);
    }   
}
    return result;
}

// Метод вывода двумерного массива
void PrintDoubleArray (int[,] DoubleArray, string message)
{
    Console.WriteLine("\n"+ message);
    for (int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            Console.Write($"{DoubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}
// Метод разворота массива
int [,] ReversMatrix(int [,] matrix)
{
    int [] firstRow = new int [matrix.GetLength(1)];
    int [] secondRow = new int [matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        firstRow[i] = matrix[0,i];
    }

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        secondRow[i] = matrix[matrix.GetLength(0) - 1, i];
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0) {matrix[i, j] = secondRow[j];} 
            if (i == matrix.GetLength(0) - 1) {matrix[i, j] = firstRow[j];}
        }   
    }

    return matrix;

}

int [,] DoubleArray = ArrayGenerator(10, 4, -99, 99);
PrintDoubleArray(DoubleArray, "Сгенирированный массив: ");
PrintDoubleArray(ReversMatrix(DoubleArray), "Перевернутый массив: ");