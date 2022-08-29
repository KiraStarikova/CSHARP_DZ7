// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for(int row = 0; row < rowCount; ++row)
    {
        for(int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); ++row) 
    {
        for(int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
        
    }
}

void PrintSum(int[,] arr)
{  
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{Math.Round(sum / arr.GetLength(0), 2)}\t");
    }
}

int[,] matrix = CreateMatrix(3,4,0,10);
PrintMatrix(matrix);
Console.WriteLine("---------------------------");
PrintSum(matrix);