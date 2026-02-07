using System;

namespace oap_labs.Lab1
{
    public static class Task3
    {
        public static void Solve()
        {
            Console.WriteLine("=== Сумма цифр трехзначного числа ===");
            Console.Write("Введите трехзначное число: ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            
            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;
            
            int sum = digit1 + digit2 + digit3;
            
            Console.WriteLine($"Число: {number}");
            Console.WriteLine($"Цифры: {digit1}, {digit2}, {digit3}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine();
        }
    }
}