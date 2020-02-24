namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Numerate.
    /// </summary>
    public class NumerateRes<T>
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
        /// Конструктор для NumerateRes.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="index">Индекс элемента.</param>
        public NumerateRes(T item, int index)
        {
            Item = item;
            Index = index;
        }

        /// <summary>
        /// Деконструктор для NumerateRes.
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
        public override string ToString()
        {
            return $"[{Item.NilOrString()} - {Index.NilOrString()}]";
        }
    }
}