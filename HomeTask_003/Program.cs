/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void PrintDoubleArray (int[,] doubleArray, string message)
{
    Console.WriteLine("\n"+ message);
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]} ");
        }
        Console.WriteLine ();   
    }
}

// Метод который производит произведение матриц
 void MatrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] result = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

    if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0)) 
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        return;
    }
            

            for (int i = 0; i < matrixFirst.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSecond.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixSecond.GetLength(0); k++)
                    {
                        result[i,j] += matrixFirst[i,k] * matrixSecond[k,j];
                    }
                }
            }
            PrintDoubleArray(result, "Перемноженная матрица :");
}

int [,] doubleArrayFirst = ArrayGenerator(5, 3, 0, 10);
PrintDoubleArray(doubleArrayFirst, "Сгенирированный массив №1 : ");
int [,] doubleArraySecond = ArrayGenerator(3, 5, 0, 10);
PrintDoubleArray(doubleArraySecond, "Сгенирированный массив №2 : ");
MatrixMultiplication(doubleArrayFirst, doubleArraySecond);