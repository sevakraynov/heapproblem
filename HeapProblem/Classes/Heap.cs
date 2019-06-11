using System.Collections.Generic;
using System.Linq;

namespace HeapProblem.Classes
{
    /// <summary>
    /// Класс кучи
    /// </summary>
    public class Heap
    {
        public Heap()
        {
            StoneList = new List<Stone>();
        }

        /// <summary>
        /// Порядковый номер кучи
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Вес кучи
        /// </summary>
        public int Weight => StoneList.Sum(stone => stone.Weight);

        /// <summary>
        /// Коллекция камней кучи
        /// </summary>
        public List<Stone> StoneList { get; set; }
    }
}
