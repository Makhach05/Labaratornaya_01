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
            
            Console.WriteLine($"Средний балл: {average}");
            
            // Задача с рекурсией
            Console.WriteLine($"\nФакториал 5: {Factorial(5)}");
        }
        
        private static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            
            // Ошибка: начинаем с 1 вместо 0
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            // Ошибка: деление целых чисел
            return sum / numbers.Length;
        }
        
        private static int Factorial(int n)
        {
            // Ошибка: бесконечная рекурсия (нет условия выхода)
            return n * Factorial(n - 1);
        }
    }
}
