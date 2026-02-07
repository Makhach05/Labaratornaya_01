using System;

namespace oap_labs.Lab3
{
    public static class Task2_Points
    {
        public static void Solve()
        {
            Console.WriteLine("=== Задача 2: Ближайшая точка к началу координат ===");
            Console.WriteLine("Программа сравнивает две точки и определяет,");
            Console.WriteLine("какая из них ближе к центру координат (0, 0)\n");
            
            Console.WriteLine("✏️ Введите координаты ПЕРВОЙ точки (x1 y1 через пробел):");
            Console.Write(">>> ");
            string[] point1 = Console.ReadLine().Split(' ');
            double x1 = Convert.ToDouble(point1[0]);
            double y1 = Convert.ToDouble(point1[1]);
            
            Console.WriteLine("\n✏️ Введите координаты ВТОРОЙ точки (x2 y2 через пробел):");
            Console.Write(">>> ");
            string[] point2 = Console.ReadLine().Split(' ');
            double x2 = Convert.ToDouble(point2[0]);
            double y2 = Convert.ToDouble(point2[1]);
            
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);
            
            Console.WriteLine("\n📊 Результаты измерений:");
            Console.WriteLine($"   Точка 1 ({x1}, {y1}): расстояние = {distance1:F2}");
            Console.WriteLine($"   Точка 2 ({x2}, {y2}): расстояние = {distance2:F2}");
            
            Console.WriteLine("\n🎯 Вывод:");
            
            if (Math.Abs(distance1 - distance2) < 0.001)
            {
                Console.WriteLine("   📍 Обе точки находятся на ОДИНАКОВОМ расстоянии!");
                Console.WriteLine($"   Расстояние: {distance1:F2} единиц");
            }
            else if (distance1 < distance2)
            {
                Console.WriteLine($"   🏆 Точка 1 ({x1}, {y1}) БЛИЖЕ к началу координат");
                Console.WriteLine($"   Разница: {distance2 - distance1:F2} единиц");
            }
            else
            {
                Console.WriteLine($"   🏆 Точка 2 ({x2}, {y2}) БЛИЖЕ к началу координат");
                Console.WriteLine($"   Разница: {distance1 - distance2:F2} единиц");
            }
            
            Console.WriteLine("\n" + new string('=', 50));
        }
    }
}