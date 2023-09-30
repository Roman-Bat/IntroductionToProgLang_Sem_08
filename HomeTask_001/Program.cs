/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
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

// Метод сортировки строк массива
int[,] SortRowsMatrix(int [,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // цикл прохода по строкам
    {
        for (int m = 0; m < matrix.GetLength(1); m++) // цикл прохода по одной строке нужное количество раз
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++) // цикл прохода по столбцам
            {
                if (matrix[i, j] < matrix[i, j + 1])
                        {
                            temp = matrix[i, j];
                            matrix[i, j] = matrix[i, j+1];
                            matrix[i, j + 1] = temp;
                        }
            }
        }  
    }
    return matrix;
} 

int [,] DoubleArray = ArrayGenerator(3, 3, 0, 10);
PrintDoubleArray(DoubleArray, "Сгенирированный массив: ");
PrintDoubleArray(SortRowsMatrix(DoubleArray), "Массив с отсортированными значениями строк по убыванию:");