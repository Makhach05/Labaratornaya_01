using System;

namespace oap_labs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА №3 - ВЕТВЛЕНИЯ В C# ===");
            Console.WriteLine("Студент: Абдулсаидов М.У. Группа: 22-ИС");
            Console.WriteLine("===============================================\n");
            
            // Запускаем все 5 задач лабораторной 3
            Lab3.Task1_Triangle.Solve();
            Lab3.Task2_Points.Solve();
            Lab3.Task3_Coordinates.Solve();
            Lab3.Task4_Circle.Solve();
            Lab3.Task5_Numbers.Solve();
            
            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine(" Все задачи лабораторной работы №3 выполнены!");
            Console.Write("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}