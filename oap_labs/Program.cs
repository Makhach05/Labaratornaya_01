using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА №4: ЦИКЛЫ");
            Console.WriteLine("===============================\n");
            
            bool exit = false;
            
            while (!exit)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1. Сумма ряда (цикл for)");
                Console.WriteLine("2. Числа Фибоначчи (цикл while)");
                Console.WriteLine("3. Угадай число (цикл do-while)");
                Console.WriteLine("4. Прямоугольник (вложенные циклы)");
                Console.WriteLine("5. Все задачи по порядку");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");
                
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                switch (choice)
                {
                    case "1":
                        Task1_ForLoop.Solve();
                        break;
                    case "2":
                        Task2_WhileLoop.Solve();
                        break;
                    case "3":
                        Task3_DoWhileLoop.Solve();
                        break;
                    case "4":
                        Task4_NestedLoops.Solve();
                        break;
                    case "5":
                        Task1_ForLoop.Solve();
                        Console.WriteLine("\n" + new string('-', 30));
                        Task2_WhileLoop.Solve();
                        Console.WriteLine("\n" + new string('-', 30));
                        Task3_DoWhileLoop.Solve();
                        Console.WriteLine("\n" + new string('-', 30));
                        Task4_NestedLoops.Solve();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
                
                if (!exit)
                {
                    Console.WriteLine("\n" + new string('=', 50));
                    Console.WriteLine();
                }
            }
            
            Console.WriteLine("Работа завершена.");
        }
    }
}