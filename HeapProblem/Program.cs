﻿using System;
using System.Collections.Generic;
using System.Linq;
using HeapProblem.Classes;

namespace HeapProblem
{
    class Program
    {
        /// <summary>
        /// Количсетво куч
        /// </summary>
        public static int CountOfHeap { get; set; }
        
        /// <summary>
        /// Инициализация
        /// </summary>
        public static void Init()
        {
            var tryCount = 1;
            int countOfHeap;
            Console.Write($"Введите количество куч (от {Settings.LeftBound} до {Settings.RightBound}): ");

            // Проверка на "дурака" (1)
            var tryParse = int.TryParse(Console.ReadLine(), out countOfHeap);
            while (!tryParse)
            {
                if (tryCount < Settings.TryCount)
                {
                    Console.WriteLine($"Некорректное число. Повторите попытку ({tryCount}/{Settings.TryCount}).");
                    tryCount++;
                    tryParse = int.TryParse(Console.ReadLine(), out countOfHeap);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            
            // Проверка на "дурака" (2)
            if (countOfHeap > Settings.RightBound || countOfHeap < Settings.LeftBound)
            {
                Console.WriteLine($"Число не лежит в заданном отрезке [{Settings.LeftBound}, {Settings.RightBound}]");
                Console.WriteLine("Завершение работы...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            CountOfHeap = countOfHeap;
        }

        /// <summary>
        /// Жадный алгоритм
        /// </summary>
        public static void Algorithm()
        {
            var stoneList = new List<Stone>();
            var heapList = new List<Heap>();
            var random = new Random();
            Heap minIndex = null;
            
            // Инициализация куч с нулевым весом
            for (int i = 0; i < CountOfHeap; i++)
            {
                heapList.Add(new Heap{ Number = i + 1 });
            }

            // Генерация радомного камня и добавление в общую кучу
            for (int i = 0; i < Settings.CountOfStones; i++)
            {
                var stone = new Stone { Weight = random.Next(1, 11) };
                stoneList.Add(stone);
                Console.WriteLine($"Камень: {{№: {i + 1}, W: {stone.Weight}}}");
            }

            Console.WriteLine();
            // Сортируем список камней общей кучи по убыванию весов
            stoneList = stoneList.OrderByDescending(q => q.Weight).ToList();

            // Для каждого камня из общего списка камней
            foreach (var item in stoneList)
            {
                // Находим кучу с минимальным весом
                minIndex = heapList.MinHeap();

                // Кладем камень в кучу с минимальным весом
                minIndex.StoneList.Add(item);
            }

            // Выводим информацию о полученных кучах
            foreach (var heap in heapList)
            {
                Console.WriteLine($"Куча {{No: {heap.Number}, W: {heap.Weight}}}");
            }

            // Максимальная куча среди куч с минимальным весом
            var maxMinHeap = heapList.MaxHeap();

            Console.WriteLine();
            Console.WriteLine($"Наибольшая куча: {{No: {maxMinHeap.Number}, W: {maxMinHeap.Weight}}}");
        }

        static void Main(string[] args)
        {
            Init();

            Algorithm();

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}
