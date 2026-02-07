using System;

namespace oap_labs.Lab3
{
    public static class Task4_Circle
    {
        public static void Solve()
        {
            Console.WriteLine("=== Задача 4: Принадлежность точки окружности ===");
            Console.WriteLine("Программа проверяет, где находится точка относительно");
            Console.WriteLine("окружности с центром в начале координат (0, 0)\n");
            
            Console.Write("✏️ Введите координаты точки (x y через пробел): ");
            Console.Write(">>> ");
            string[] point = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(point[0]);
            double y = Convert.ToDouble(point[1]);
            
            Console.Write("\n✏️ Введите радиус окружности (положительное число): ");
            Console.Write(">>> ");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            if (radius <= 0)
            {
                Console.WriteLine("\n❌ ОШИБКА: Радиус должен быть положительным числом!");
                return;
            }
            
            double distance = Math.Sqrt(x * x + y * y);
            
            Console.WriteLine("\n📊 Вычисления:");
            Console.WriteLine($"   Координаты точки: ({x}, {y})");
            Console.WriteLine($"   Радиус окружности: {radius:F2}");
            Console.WriteLine($"   Расстояние до центра: {distance:F2}");
            
            Console.WriteLine("\n🎯 Результат:");
            
            double epsilon = 0.0001;
            
            if (Math.Abs(distance - radius) < epsilon)
            {
                Console.WriteLine("   🎯 Точка лежит НА ОКРУЖНОСТИ (на границе)");
                Console.WriteLine($"   Точное расстояние: {distance:F6}");
            }
            else if (distance < radius)
            {
                Console.WriteLine("   ✅ Точка лежит ВНУТРИ окружности");
                Console.WriteLine($"   От центра до границы: {radius - distance:F2}");
            }
            else
            {
                Console.WriteLine("   ❌ Точка лежит СНАРУЖИ окружности");
                Console.WriteLine($"   Не хватает до границы: {distance - radius:F2}");
            }
            
            Console.WriteLine("\n📐 Графическое представление:");
            Console.WriteLine($"   Центр окружности: (0, 0)");
            Console.WriteLine($"   Радиус окружности: {radius}");
            Console.WriteLine($"   Точка: ({x}, {y})");
            Console.WriteLine($"   Дистанция точка-центр: {distance:F2}");
            
            Console.WriteLine("\n" + new string('=', 50));
        }
    }
}