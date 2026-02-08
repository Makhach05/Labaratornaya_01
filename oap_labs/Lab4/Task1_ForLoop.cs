using System;

namespace Lab4
{
    public static class Task1_ForLoop
    {
        public static void Solve()
        {
            Console.WriteLine("=== ЗАДАЧА 1: Вычисление суммы ряда (for) ===");
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            
            int sum = 0;
            Console.Write("Ряд чисел: ");
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
                sum += i;
                
                if (i < n)
                    Console.Write("+ ");
            }
            
            Console.WriteLine($"\nСумма = {sum}");
        }
    }
}
