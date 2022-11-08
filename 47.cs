
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine(" ");
    }
}



Console.Clear();
Console.WriteLine("введите кол-во строк");
int linesVolume = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов");
int columnsVolume = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVolume, columnsVolume];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

