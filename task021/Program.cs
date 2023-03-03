Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);
Console.WriteLine("Расстояние = " + d);
