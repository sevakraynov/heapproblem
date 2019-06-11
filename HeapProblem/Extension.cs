using System;
using System.Collections.Generic;
using HeapProblem.Classes;

namespace HeapProblem
{
    /// <summary>
    /// Класс расширений
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Поиск кучи с минимальным весом
        /// </summary>
        /// <param name="heapList">Перечислитель с типом Heap</param>
        /// <returns>Куча с минимальным весом</returns>
        public static Heap MinHeap(this IEnumerable<Heap> heapList)
        {
            if (heapList == null)
                throw new ArgumentNullException("source");

            int minValue = int.MaxValue;
            Heap minHeap = null;

            foreach (var heap in heapList)
            {
                if (heap.Weight <= minValue)
                {
                    minValue = heap.Weight;
                    minHeap = heap;
                }
            }

            if (minHeap == null)
                throw new InvalidOperationException("Sequence was empty");

            return minHeap;
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
