using System;

namespace oap_labs.Lab1
{
    public static class Task2
    {
        public static void Solve()
        {
            Console.WriteLine("=== Прямоугольный треугольник ===");
            
            Console.Write("Введите длину первого катета: ");
            double katet1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите длину второго катета: ");
            double katet2 = Convert.ToDouble(Console.ReadLine());
            
            double hypotenuse = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
            double area = (katet1 * katet2) / 2;
            double perimeter = katet1 + katet2 + hypotenuse;
            
            Console.WriteLine($"Гипотенуза: {hypotenuse:F2}");
            Console.WriteLine($"Площадь: {area:F2}");
            Console.WriteLine($"Периметр: {perimeter:F2}");
            Console.WriteLine();
        }
    }
}