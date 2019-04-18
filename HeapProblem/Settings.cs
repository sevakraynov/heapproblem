namespace HeapProblem
{
    /// <summary>
    /// Статичный класс Настроек
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Левая граница на количество куч
        /// </summary>
        /// <value>По умолчанию: 2</value>
        public static int LeftBound { get; set; } = 2;

        /// <summary>
        /// Правая граница на количество куч
        /// </summary>
        /// <value>По умолчанию: 5</value>
        public static int RightBound { get; set; } = 5;

        /// <summary>
        /// Количество попыток на указание числа куч
        /// </summary>
        /// <value>По умолчанию: 5</value>
        public static int TryCount { get; set; } = 5;

        /// <summary>
        /// Количество камней
        /// </summary>
        /// <value>По умолчанию: 40</value>
        public static int CountOfStones { get; set; } = 10;
    }
}
