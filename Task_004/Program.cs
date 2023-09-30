/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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
            Console.Write($"{DoubleArray[i, j]}  ");
        }
        Console.WriteLine ();   
    }
}

// Метод поиска наименьшего элемента массива
int[,] MinimalElementArray(int [,] matrix)
{
    int temp = matrix[0,0];
    int rows = 0;
    int colums = 0;
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(temp > matrix[i,j])
            {
                rows = i;
                colums = j;
                temp = matrix[i,j];
            }    
        }  
    }

    Console.WriteLine($"\nМинимальное число = {temp} \nCтрока в массиве = {rows + 1} \nCтолбец в массиве = {colums + 1}");

    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int resultRow = 0;
    int resultColum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i == rows) i ++;
        resultColum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             if (j == colums) j++ ;                          
             result[resultRow, resultColum] = matrix[i, j];
             resultColum ++;
        }

        resultRow ++;
    }
    return result;
}


int [,] doubleArray = ArrayGenerator(4, 4, 0, 10);
PrintDoubleArray(doubleArray, "Сгенирированный массив: ");
PrintDoubleArray(MinimalElementArray(doubleArray), "Новый массив без строки и столбца на пересечении минимального числа: ");