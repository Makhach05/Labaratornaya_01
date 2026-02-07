using System;
using oap_labs.Lab1;

namespace oap_labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("======================\n");
            
            // Запуск решения всех задач
            Task1.Solve();
            Task2.Solve();
            Task3.Solve();
            
            // Ожидание нажатия Enter
            Console.Write("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}