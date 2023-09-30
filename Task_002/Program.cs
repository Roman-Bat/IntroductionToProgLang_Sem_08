/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
// Метод проверки на возможность замены срок на столбцы

bool checkMatrix(int[,] checkMatrix)
{
    bool result = true;
    if (checkMatrix.GetLength(0) != checkMatrix.GetLength(1))
    {
        result = false;
    }
    return result;
}

// Метод разворота массива
int [,] ReversMatrix(int [,] matrix)
{
   int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix [i, j];
        }   
    } 

   return newMatrix;

}

int [,] doubleArray = ArrayGenerator(4, 4, 0, 10);
PrintDoubleArray(doubleArray, "Сгенирированный массив: ");
if (checkMatrix(doubleArray) == false) {Console.WriteLine("Невозможно заменить строки столбцами");}
else {PrintDoubleArray(ReversMatrix(doubleArray), "Массив с заменой строк на столбцы: ");}
