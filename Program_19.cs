Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
n = n * (-1);
while (n < 10000 || n > 99999)
{
Console.Write("Введите пятизначное число: ");
n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
Console.WriteLine("Палиндром");
else
Console.WriteLine("НЕ палиндром");