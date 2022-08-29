// программa, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

int PrintFindElement(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)   
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          
            if (arr[i, j] == num)
                Console.WriteLine($"Элемент массива: {num} существует " + (i, j));
                   
        }
    }
    return num;
}

int[,] matrix = CreateMatrix(3,4,0,10);
PrintMatrix(matrix);
int number = 3;
Console.WriteLine("элемент массива не существует");
PrintFindElement(matrix,number);