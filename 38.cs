void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
}

int CalcNumbers(int[] array)
{
    int min = array [0];
    int max = array [0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        max = array[i];
        else if (min > array[i])
        min = array[i];
    }
    
    return max - min;
}

Console.Write("Ввыдите количество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Разница между MAX и MIN {CalcNumbers(array)}");
