using System;

namespace Lab4
{
    public static class Task2_WhileLoop
    {
        public static void Solve()
        {
            Console.WriteLine("=== ЗАДАЧА 2: Числа Фибоначчи (while) ===");
            Console.Write("Сколько чисел вывести? ");
            int count = int.Parse(Console.ReadLine());
            
            int a = 0, b = 1, c;
            int i = 0;
            
            Console.Write("Ряд Фибоначчи: ");
            
            while (i < count)
            {
                Console.Write($"{a} ");
                c = a + b;
                a = b;
                b = c;
                i++;
            }
            Console.WriteLine();
        }
    }
}
