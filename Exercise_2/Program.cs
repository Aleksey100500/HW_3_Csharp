/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
class Program
{
    static void Main (string[] args)
    {
        Console.Write("Введите координату Первой точки Х - ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Первой точки Y - ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Первой точки Z - ");
        double z = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Первой точки Х1 - ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Первой точки Y1 - ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Первой точки Z1 - ");
        double z1 = Convert.ToDouble(Console.ReadLine());

        double a = Math.Pow(x1 - x, 2);
        double b = Math.Pow(y1 - y, 2);
        double c = Math.Pow(z1 - z, 2);

        double result = Math.Sqrt(a + b + c);

        Console.WriteLine($"{result}");
    }
}