/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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
// метод частотного словаря
void FrenqDictionary(int[] array)
{
    int temp = array[0];
    int counter = 1;
    string value = "";
    for (int i = 1; i < array.Length; i++)
    {
        if (temp == array[i]) counter++;
        else 
        {
            if (counter == 2 || counter == 3 || counter == 4) value = "раза";
            else {value = "раз";}
            Console.WriteLine($"Число {temp} встречается в массиве {counter} {value}");
            temp = array[i];
            counter = 1;
        }
    }
    if (counter == 2 || counter == 3 || counter == 4) value = "раза";
    else {value = "раз";}
    Console.WriteLine($"Число {temp} встречается в массиве {counter} {value}");
}
// Метод преобразования двумерного массива в одномерный
int [] OneLineArray (int [,] matrix)
{
    int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
           for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[counter] = matrix[i, j];
                counter ++;
            }
    }
    for (int m = 0; m < result.Length; m ++)
    {
        Console.Write($"{result[m]} ");
    }
    return result;
}

// Метод сортировки одномерного массива
int [] SortArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j + 1] = temp;
                    }
                }
            }
    
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]} ");
      }
    return array;
}

int [,] doubleArray = ArrayGenerator(4, 4, 0, 10);
PrintDoubleArray(doubleArray, "Сгенирированный массив: ");
Console.WriteLine("\n Перевод массива в одномерный: ");
int[] oneLineArray = OneLineArray(doubleArray);
Console.WriteLine("\n \n Сортировка значений одномерного массива:");
int[] sortArray = SortArray(oneLineArray);
Console.WriteLine();
FrenqDictionary(sortArray);