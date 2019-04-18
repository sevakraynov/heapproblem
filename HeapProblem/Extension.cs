using System;
using System.Collections.Generic;

namespace HeapProblem
{
    /// <summary>
    /// Класс расширений
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Метод поиска индекса минимального элемента
        /// </summary>
        /// <param name="source">Перечислитель с типом Heap</param>
        /// <returns>Индекс минимального элемента, иначе -1</returns>
        public static int IndexOfMin(this IEnumerable<Heap> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            int minValue = int.MaxValue;
            int minIndex = -1;
            int index = -1;

            foreach (var item in source)
            {
                index++;

                if (item.Weight <= minValue)
                {
                    minValue = item.Weight;
                    minIndex = index;
                }
            }

            if (index == -1)
                throw new InvalidOperationException("Sequence was empty");

            return minIndex;
        }
        
        /// <summary>
        /// Поиск кучи с максимальным весом
        /// </summary>
        /// <param name="source">Перечислитель с типом Heap</param>
        /// <returns>Куча с максимальным весом</returns>
        public static Heap MaxHeap(this IEnumerable<Heap> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            int maxValue = int.MinValue;
            Heap maxHeap = null;

            foreach (var item in source)
            {

                if (item.Weight > maxValue)
                {
                    maxValue = item.Weight;
                    maxHeap = item;
                }
            }

            if (maxHeap == null)
                throw new InvalidOperationException("Sequence was empty");

            return maxHeap;
        }
    }
}
