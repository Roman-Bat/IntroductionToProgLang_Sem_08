/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

// Метод нахождения  минимальной суммы строк
void MinimalRowSum(int [,] matrix)
{
    int[] sumRow = new int[matrix.GetLength(0)];
    
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++) // цикл прохода по строкам
    {
        sumRow[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) // цикл прохода по столбцам
            {
                sumRow[i] += matrix[i,j]; 
            }
            Console.WriteLine($"Сумма элементов строки {i + 1} равна {sumRow[i]}");
    }

    int index = 1;
    int temp = sumRow[0];
    for (int i = 0; i < sumRow.Length; i++)
        {
            if (temp > sumRow[i]) 
                {
                    temp = sumRow[i];
                    index = i + 1; 
                }
            
                
                
        }

    Console.WriteLine($"\nСтрока с наименьшей суммой элементов {index}");

} 

int [,] doubleArray = ArrayGenerator(4, 5, 0, 10);
PrintDoubleArray(doubleArray, "Сгенирированный массив: ");
MinimalRowSum(doubleArray);