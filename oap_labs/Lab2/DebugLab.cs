using System;

namespace oap_labs.Lab2
{
    public static class DebugLab
    {
        public static void RunDebugExercises()
        {
            Console.WriteLine("=== Лабораторная работа №2: Отладка ===");
            
            // Задача 1: Деление на ноль
            Task1_DivisionByZero();
            
            // Задача 2: Выход за границы массива
            Task2_ArrayBounds();
            
            // Задача 3: Логическая ошибка в расчетах
            Task3_LogicalError();
            
            // Задача 4: Работа со строками
            Task4_StringOperations();
            
            Console.WriteLine("\nОтладка завершена!");
        }
        
        // Задача 1: Деление на ноль (Runtime Error) - ИСПРАВЛЕНО
        private static void Task1_DivisionByZero()
        {
            Console.WriteLine("\n--- Задача 1: Деление на ноль ---");
            
            int[] numbers = { 10, 5, 0, 2 };
            int divisor = 0;
            
            // ИСПРАВЛЕНО: i < numbers.Length вместо i <= numbers.Length
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 2)
                {
                    divisor = numbers[i]; // divisor станет 0
                }
                
                // ИСПРАВЛЕНО: добавили проверку перед делением
                if (divisor != 0)
                {
                    int result = numbers[i] / divisor;
                    Console.WriteLine($"{numbers[i]} / {divisor} = {result}");
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} / {divisor} = [деление на ноль]");
                }
            }
        }
        
        // Задача 2: Выход за границы массива (Runtime Error) - ИСПРАВЛЕНО
        private static void Task2_ArrayBounds()
        {
            Console.WriteLine("\n--- Задача 2: Работа с массивом ---");
            
            int[] array = new int[5];
            
            // Заполнение массива
            // ИСПРАВЛЕНО: i < 5 вместо i <= 5
            for (int i = 0; i < 5; i++)
            {
                array[i] = i * 2;
            }
            
            // Вывод массива
            Console.Write("Массив: ");
            // ИСПРАВЛЕНО: i < array.Length вместо i <= array.Length
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        
        // Задача 3: Логическая ошибка в расчетах (Logical Error) - ИСПРАВЛЕНО
        private static void Task3_LogicalError()
        {
            Console.WriteLine("\n--- Задача 3: Расчет скидки ---");
            
            double price = 1000;
            int discountPercent = 15;
            
            // ИСПРАВЛЕНО: правильные формулы расчета
            double discountAmount = price * discountPercent / 100; // Было: price / discountPercent
            double finalPrice = price - discountAmount; // Было: price + discountAmount
            
            Console.WriteLine($"Цена: {price} руб.");
            Console.WriteLine($"Скидка: {discountPercent}%");
            Console.WriteLine($"Сумма скидки: {discountAmount:F2} руб.");
            Console.WriteLine($"Итоговая цена: {finalPrice:F2} руб.");
        }
        
        // Задача 4: Работа со строками (Null Reference) - ИСПРАВЛЕНО
        private static void Task4_StringOperations()
        {
            Console.WriteLine("\n--- Задача 4: Обработка строк ---");
            
            string[] names = { "Анна", null, "Иван", "", "Мария" };
            
            int totalLength = 0;
            for (int i = 0; i < names.Length; i++)
            {
                // ИСПРАВЛЕНО: проверка на null перед вызовом Length
                if (names[i] != null)
                {
                    totalLength += names[i].Length;
                    Console.WriteLine($"Имя: '{names[i]}', Длина: {names[i].Length}");
                }
                else
                {
                    Console.WriteLine($"Имя: [null], Длина: 0");
                }
            }
            
            Console.WriteLine($"Общая длина всех имен: {totalLength}");
        }
    }
}