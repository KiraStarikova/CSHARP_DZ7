// двумерный массив размером m×n,
// заполненный случайными вещественными числами. m = 3, n = 4.

double[,] CreateMatrix(int rowCount, int columnCount, double min, double max)
{
    double[,] array = new double[rowCount, columnCount];
    Random random = new Random();
    for(int row = 0; row < rowCount; ++row)
    {
        for(int column = 0; column < columnCount; column++)
        {
            array[row, column] = random.NextDouble() * 100;
        }
        
        Console.WriteLine();
    }
    return array;
}

void PrintMatrix(double[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); ++row) 
    {
        for(int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{Math.Round(arr[row, column], 2)} \t");
             
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(matrix);