using System;

namespace oap_labs.Lab2
{
    public static class AdditionalDebug
    {
        public static void DebugComplexTask()
        {
            Console.WriteLine("\n=== Дополнительная задача: Калькулятор среднего ===");
            
            int[] scores = { 85, 90, 78, 92, 88 };
            double average = CalculateAverage(scores);
            
            Console.WriteLine($"Средний балл: {average:F2}");
            
            // Задача с рекурсией
            Console.WriteLine($"\nФакториал 5: {Factorial(5)}");
            
            // Дополнительная проверка
            Console.WriteLine($"\nФакториал 0: {Factorial(0)}");
            Console.WriteLine($"Факториал 1: {Factorial(1)}");
        }
        
        private static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            
            // ИСПРАВЛЕНО: начинаем с 0 вместо 1
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            // ИСПРАВЛЕНО: приведение к double для точного деления
            return (double)sum / numbers.Length;
        }
        
        private static int Factorial(int n)
        {
            // ИСПРАВЛЕНО: добавили условие выхода из рекурсии
            if (n <= 1)
                return 1;
            
            return n * Factorial(n - 1);
        }
    }
}