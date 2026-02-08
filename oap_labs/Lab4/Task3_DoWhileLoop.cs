using System;

namespace Lab4
{
    public static class Task3_DoWhileLoop
    {
        public static void Solve()
        {
            Console.WriteLine("=== ЗАДАЧА 3: Угадай число (do-while) ===");
            Random random = new Random();
            int secret = random.Next(1, 101);
            int attempts = 0;
            int guess;
            
            Console.WriteLine("Загадано число от 1 до 100");
            
            do
            {
                attempts++;
                Console.Write($"Попытка {attempts}: ");
                guess = int.Parse(Console.ReadLine());
                
                if (guess < secret)
                    Console.WriteLine("Слишком мало!");
                else if (guess > secret)
                    Console.WriteLine("Слишком много!");
                    
            } while (guess != secret);
            
            Console.WriteLine($"Поздравляем! Угадали за {attempts} попыток.");
        }
    }
}
