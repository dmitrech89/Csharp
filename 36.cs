void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11);
}

int CalcNumbers(int[] array)
{
    int calc = 0;
    for (int i = 1; i < array.Length; i= i + 2)
        calc = calc + array[i];
    
    return calc;
}

Console.Write("Ввыдите количество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Cумма нечетных элементов: {CalcNumbers(array)}");
