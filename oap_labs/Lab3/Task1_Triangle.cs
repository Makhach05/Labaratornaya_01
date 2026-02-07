using System;

namespace oap_labs.Lab3
{
    public static class Task1_Triangle
    {
        public static void Solve()
        {
            Console.WriteLine("=== Задача 1: Проверка треугольника по углам ===");
            Console.WriteLine("Программа определяет, может ли существовать треугольник");
            Console.WriteLine("с заданными углами, и если да - какой он тип\n");
            
            Console.Write("Введите первый угол треугольника (в градусах): ");
            double angle1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Введите второй угол треугольника (в градусах): ");
            double angle2 = Convert.ToDouble(Console.ReadLine());
            
            double angle3 = 180 - angle1 - angle2;
            
            Console.WriteLine($"\n📐 Вычислен третий угол: {angle3:F2}°");
            Console.WriteLine("--- Анализ треугольника ---");
            
            if (angle1 > 0 && angle2 > 0 && angle3 > 0)
            {
                Console.WriteLine("✅ Треугольник СУЩЕСТВУЕТ!");
                
                if (Math.Abs(angle1 - 90) < 0.001 || 
                    Math.Abs(angle2 - 90) < 0.001 || 
                    Math.Abs(angle3 - 90) < 0.001)
                {
                    Console.WriteLine("   📐 Тип: ПРЯМОУГОЛЬНЫЙ (один угол равен 90°)");
                }
                else if (angle1 > 90 || angle2 > 90 || angle3 > 90)
                {
                    Console.WriteLine("   📏 Тип: ТУПОУГОЛЬНЫЙ (один угол больше 90°)");
                }
                else
                {
                    Console.WriteLine("   🔺 Тип: ОСТРОУГОЛЬНЫЙ (все углы меньше 90°)");
                }
            }
            else
            {
                Console.WriteLine("❌ Треугольник НЕ СУЩЕСТВУЕТ!");
                Console.WriteLine("   Причина: сумма углов ≠ 180° или есть неположительные углы");
            }
            
            Console.WriteLine("\n" + new string('=', 50));
        }
    }
}