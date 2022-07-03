// Нахождение расстояния между двумя точками в 3D-пространстве
Console.WriteLine ("Введите координаты первой точки по оси X: ");
int x1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координаты первой точки по оси Y: ");
int y1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координаты первой точки по оси Z: ");
int z1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки по оси X: ");
int x2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки по оси Y: ");
int y2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки по оси Z: ");
int z2 = Convert.ToInt32 (Console.ReadLine ());

int qq (int a, int b)
    {
        int c = (b - a) * (b - a);
        return c;
    }

double s = Math.Sqrt (qq (x1, x2) + qq (y1, y2) + qq (z1, z2));
Console.WriteLine ("A (" + x1 + "," + y2 + "," + z1 + "); " + "B (" + x2 + "," + y2 + "," + z2 + ") " + "-> " + s);