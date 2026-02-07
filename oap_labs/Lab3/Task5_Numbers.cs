using System;

namespace oap_labs.Lab3
{
    public static class Task5_Numbers
    {
        public static void Solve()
        {
            Console.WriteLine("=== Задача 5: Условное возведение в степень ===");
            Console.WriteLine("Программа обрабатывает три числа:");
            Console.WriteLine("- Неотрицательные числа → возводит в КВАДРАТ");
            Console.WriteLine("- Отрицательные числа → возводит в 4-ю СТЕПЕНЬ\n");
            
            Console.Write("✏️ Введите три числа через пробел: ");
            Console.Write(">>> ");
            string[] inputs = Console.ReadLine().Split(' ');
            
            double a = Convert.ToDouble(inputs[0]);
            double b = Convert.ToDouble(inputs[1]);
            double c = Convert.ToDouble(inputs[2]);
            
            Console.WriteLine("\n📊 Исходные данные:");
            Console.WriteLine($"   Число 1: {a}");
            Console.WriteLine($"   Число 2: {b}");  
            Console.WriteLine($"   Число 3: {c}");
            
            Console.WriteLine("\n⚡️ Обработка чисел:");
            
            double resultA = (a >= 0) ? Math.Pow(a, 2) : Math.Pow(a, 4);
            string operationA = (a >= 0) ? "квадрат" : "4-я степень";
            Console.WriteLine($"   1. {a} → {operationA} = {resultA:F2}");
            
            double resultB = (b >= 0) ? Math.Pow(b, 2) : Math.Pow(b, 4);
            string operationB = (b >= 0) ? "квадрат" : "4-я степень";
            Console.WriteLine($"   2. {b} → {operationB} = {resultB:F2}");
            
            double resultC = (c >= 0) ? Math.Pow(c, 2) : Math.Pow(c, 4);
            string operationC = (c >= 0) ? "квадрат" : "4-я степень";
            Console.WriteLine($"   3. {c} → {operationC} = {resultC:F2}");
            
            Console.WriteLine("\n📈 Статистика:");
            int positiveCount = 0;
            int negativeCount = 0;
            
            if (a >= 0) positiveCount++; else negativeCount++;
            if (b >= 0) positiveCount++; else negativeCount++;
            if (c >= 0) positiveCount++; else negativeCount++;
            
            Console.WriteLine($"   Неотрицательных чисел: {positiveCount}");
            Console.WriteLine($"   Отрицательных чисел: {negativeCount}");
            
            double maxResult = Math.Max(resultA, Math.Max(resultB, resultC));
            Console.WriteLine($"   Максимальный результат: {maxResult:F2}");
            
            Console.WriteLine("\n" + new string('=', 50));
        }
    }
}