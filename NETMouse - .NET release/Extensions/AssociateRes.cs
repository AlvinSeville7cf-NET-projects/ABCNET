namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Associate.
    /// </summary>
    public class AssociateRes<T, TOutput>
    {
        /// <summary>
        /// Элемент.
        /// </summary>
        public T Item { get; }

        /// <summary>
        /// Проекция элемента.
        /// </summary>
        public TOutput Projection { get; }

        public AssociateRes(T item, TOutput projection)
        {
            Item = item;
            Projection = projection;
        }

        public void Deconstruct(out T item, out TOutput projection)
        {
            item = Item;
            projection = Projection;
        }

        public override string ToString()
        {
            return $"[{Item} - {Projection}]";
        }
    }
}