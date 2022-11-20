void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] linesLength = new int[4, 4];

void SumElements(int[,] array)
{
    int minRow = 0;
    int minSum = 0;
    int sumRow = 0;
    for (int i = 0; i < linesLength.GetLength(1); i++)
    {
        minRow = minRow + linesLength[0, i];
    }
    for (int i = 0; i < linesLength.GetLength(0); i++)
    {
        for (int j = 0; j < linesLength.GetLength(1); j++) sumRow =sumRow + linesLength[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSum = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSum + 1} строка");
}




FillArrayRandom(linesLength);
PrintArray(linesLength);
Console.WriteLine();
SumElements(linesLength);
