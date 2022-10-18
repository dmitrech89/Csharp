Console.Clear();
Console.Write("Введите число A : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <=B; i++)
{
  result = result * A;
  }

Console.WriteLine(A + " в степени " + B + " = " + result);