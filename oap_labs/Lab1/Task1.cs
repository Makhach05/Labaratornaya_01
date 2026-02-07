using System;

namespace oap_labs.Lab1
{
    public static class Task1
    {
        public static void Solve()
        {
            Console.WriteLine("=== Задача A+B (Сумма двух чисел) ===");
            Console.Write("Введите два целых числа через пробел: ");
            
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            
            int sum = a + b;
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine();
        }
    }
}