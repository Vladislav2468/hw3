int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int z1 = Prompt("Введите координату Y1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");
int z2 = Prompt("Введите координату Y1: ");
FindLinePlane(x1, y1, x2, y2, z1, z2);

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    int coord = Convert.ToInt32(value);
    return coord;
}

double FindLinePlane(int xa, int ya, int xb, int yb, int za, int zb)
{
    double ab = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)), 3));
    Console.WriteLine($"Расстояние между точками {ab}");
    return ab;
}