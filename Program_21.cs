Console.Clear();
Console.Write("Введите х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите у1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

double A = x2 - x1;
double B = y2 - y1;
double C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

