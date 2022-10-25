void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}

int CalcNumbers(int[] array)
{
    int calc = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        calc++;
    }
    return calc;
}

Console.Write("Ввыдите количество элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных элементов: {CalcNumbers(array)}");
