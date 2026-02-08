using System;

namespace Lab4
{
    public static class Task4_NestedLoops
    {
        public static void Solve()
        {
            Console.WriteLine("=== ЗАДАЧА 4: Прямоугольник из символов (вложенные циклы) ===");
            Console.Write("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            
            Console.Write("Введите высоту: ");
            int height = int.Parse(Console.ReadLine());
            
            Console.Write("Введите символ: ");
            char symbol = Console.ReadLine()[0];
            
            Console.WriteLine();
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
