namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Numerate.
    /// </summary>
    public class NumerateResult<T>
    {
        /// <summary>
        /// Элемент.
        /// </summary>
        public T Item { get; }

        /// <summary>
        /// Индекс.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Конструктор для NumerateResult.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="index">Индекс элемента.</param>
        public NumerateResult(T item, int index)
        {
            Item = item;
            Index = index;
        }

        /// <summary>
        /// Деконструктор для NumerateResult.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="index">Индекс элемента.</param>
        public void Deconstruct(out T item, out int index)
        {
            item = Item;
            index = Index;
        }

        /// <summary>
        /// Метод для преобразования в строку.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"[{Item.NilOrString()} - {Index.NilOrString()}]";
        }
    }
}
