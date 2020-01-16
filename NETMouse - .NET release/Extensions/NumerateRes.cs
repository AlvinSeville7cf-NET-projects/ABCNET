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


        public NumerateRes(T item, int index)
        {
            Item = item;
            Index = index;
        }

        public void Deconstruct(out T item, out int index)
        {
            item = Item;
            index = Index;
        }

        public override string ToString()
        {
            return $"[{Item} - {Index}]";
        }
    }
}