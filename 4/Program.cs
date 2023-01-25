//Найти расстояние между точками в пространстве 2D/3D
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;
    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}
double xA, yA, zA, xB, yB, zB;
double distance;
Console.Write("input X of point A: "); //3,7
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point A: "); //6,-5
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point A: "); //8,0
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("input X of point B: "); //2,1
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Y of point B: "); //1,-1
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input Z of point B: "); //-7,9
zB = Convert.ToDouble(Console.ReadLine());
distance = GetDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine(distance);