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
        
        // Задача 1: Деление на ноль (Runtime Error)
        private static void Task1_DivisionByZero()
        {
            Console.WriteLine("\n--- Задача 1: Деление на ноль ---");
            
            int[] numbers = { 10, 5, 0, 2 };
            int divisor = 0;
            
            for (int i = 0; i <= numbers.Length; i++) // Ошибка: <= вместо <
            {
                if (i == 2)
                {
                    divisor = numbers[i]; // divisor станет 0
                }
                
                int result = numbers[i] / divisor; // Деление на ноль при i=2
                Console.WriteLine($"{numbers[i]} / {divisor} = {result}");
            }
        }
        
        // Задача 2: Выход за границы массива (Runtime Error)
        private static void Task2_ArrayBounds()
        {
            Console.WriteLine("\n--- Задача 2: Работа с массивом ---");
            
            int[] array = new int[5];
            
            // Заполнение массива
            for (int i = 0; i <= 5; i++) // Ошибка: i <= 5, а размер массива 5
            {
                array[i] = i * 2;
            }
            
            // Вывод массива
            Console.Write("Массив: ");
            for (int i = 0; i <= array.Length; i++) // Ошибка: <= вместо <
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        
        // Задача 3: Логическая ошибка в расчетах (Logical Error)
        private static void Task3_LogicalError()
        {
            Console.WriteLine("\n--- Задача 3: Расчет скидки ---");
            
            double price = 1000;
            int discountPercent = 15;
            
            // Ошибка: неправильная формула расчета
            double discountAmount = price / discountPercent; // Должно быть: price * discountPercent / 100
            double finalPrice = price + discountAmount; // Должно быть: price - discountAmount
            
            Console.WriteLine($"Цена: {price} руб.");
            Console.WriteLine($"Скидка: {discountPercent}%");
            Console.WriteLine($"Сумма скидки: {discountAmount} руб.");
            Console.WriteLine($"Итоговая цена: {finalPrice} руб.");
        }
        
        // Задача 4: Работа со строками (Null Reference)
        private static void Task4_StringOperations()
        {
            Console.WriteLine("\n--- Задача 4: Обработка строк ---");
            
            string[] names = { "Анна", null, "Иван", "", "Мария" };
            
            int totalLength = 0;
            for (int i = 0; i < names.Length; i++)
            {
                // Ошибка: не проверяется на null перед вызовом Length
                totalLength += names[i].Length;
                Console.WriteLine($"Имя: '{names[i]}', Длина: {names[i].Length}");
            }
            
            Console.WriteLine($"Общая длина всех имен: {totalLength}");
        }
    }
}
