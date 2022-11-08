void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ", ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Console.Write("Введите номер строки: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArray(numbers);

if (lines > numbers.GetLength(0) || column > numbers.GetLength(1))
{
    Console.WriteLine("Нет такого элемента");
}
else
{
    Console.WriteLine($"Значение элемента {lines} строки и {column} столбца равно {numbers[lines-1,column-1]}");
}

PrintArray(numbers);


