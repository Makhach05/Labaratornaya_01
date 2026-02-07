using System;
using oap_labs.Lab1;
using oap_labs.Lab2;

namespace oap_labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторные работы по ОАП ===");
            Console.WriteLine("\nВыберите лабораторную работу:");
            Console.WriteLine("1 - Лабораторная №1 (Программы линейной структуры)");
            Console.WriteLine("2 - Лабораторная №2 (Отладка приложений)");
            Console.WriteLine("3 - Лабораторная №2 (Дополнительные упражнения)");
            Console.Write("\nВаш выбор (1, 2 или 3): ");
            
            string choice = Console.ReadLine();
            Console.WriteLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Запуск лабораторной работы №1");
                    Console.WriteLine("==============================\n");
                    Task1.Solve();
                    Task2.Solve();
                    Task3.Solve();
                    break;
                    
                case "2":
                    Console.WriteLine("Запуск лабораторной работы №2");
                    Console.WriteLine("==============================\n");
                    DebugLab.RunDebugExercises();
                    break;
                    
                case "3":
                    Console.WriteLine("Запуск дополнительных упражнений");
                    Console.WriteLine("=================================\n");
                    AdditionalDebug.DebugComplexTask();
                    break;
                    
                default:
                    Console.WriteLine("Неверный выбор! Запускается лабораторная №1 по умолчанию");
                    Console.WriteLine("======================================================\n");
                    Task1.Solve();
                    Task2.Solve();
                    Task3.Solve();
                    break;
            }
            
            Console.Write("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}