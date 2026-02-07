using System;

namespace oap_labs.Lab3
{
    public static class Task3_Coordinates
    {
        public static void Solve()
        {
            Console.WriteLine("=== Задача 3: Положение точки на плоскости ===");
            Console.WriteLine("Программа определяет, где находится точка:");
            Console.WriteLine("- в начале координат");
            Console.WriteLine("- на оси X или Y");
            Console.WriteLine("- в одном из 4-х координатных углов\n");
            
            Console.Write("✏️ Введите координаты точки (x y через пробел): ");
            Console.Write(">>> ");
            string[] coords = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(coords[0]);
            double y = Convert.ToDouble(coords[1]);
            
            Console.WriteLine($"\n📍 Анализ точки ({x}, {y}):");
            
            if (x == 0 && y == 0)
            {
                Console.WriteLine("   🎯 Точка находится в НАЧАЛЕ КООРДИНАТ (0, 0)");
                Console.WriteLine("   Это единственная точка с такими координатами!");
            }
            else if (x == 0)
            {
                Console.WriteLine("   📏 Точка лежит на ОСИ Y");
                Console.WriteLine($"   Координата по Y: {y}");
                if (y > 0)
                    Console.WriteLine("   Направление: ВВЕРХ от начала координат");
                else
                    Console.WriteLine("   Направление: ВНИЗ от начала координат");
            }
            else if (y == 0)
            {
                Console.WriteLine("   📐 Точка лежит на ОСИ X");
                Console.WriteLine($"   Координата по X: {x}");
                if (x > 0)
                    Console.WriteLine("   Направление: ВПРАВО от начала координат");
                else
                    Console.WriteLine("   Направление: ВЛЕВО от начала координат");
            }
            else
            {
                Console.WriteLine("   📍 Точка находится в КООРДИНАТНОМ УГЛУ:");
                
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("   ✅ I угол (верхний правый)");
                    Console.WriteLine("   Характеристика: обе координаты положительные");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("   ✅ II угол (верхний левый)");
                    Console.WriteLine("   Характеристика: X отрицательный, Y положительный");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("   ✅ III угол (нижний левый)");
                    Console.WriteLine("   Характеристика: обе координаты отрицательные");
                }
                else
                {
                    Console.WriteLine("   ✅ IV угол (нижний правый)");
                    Console.WriteLine("   Характеристика: X положительный, Y отрицательный");
                }
            }
            
            Console.WriteLine("\n" + new string('=', 50));
        }
    }
}