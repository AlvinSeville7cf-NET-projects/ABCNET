namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Associate.
    /// </summary>
    public class AssociateResult<T, TOutput>
    {
        /// <summary>
        /// Элемент.
        /// </summary>
        public T Item { get; }

        /// <summary>
        /// Проекция элемента.
        /// </summary>
        public TOutput Projection { get; }

        /// <summary>
        /// Конструктор для AssociateResult.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="projection">Проекция элемента.</param>
        public AssociateResult(T item, TOutput projection)
        {
            Item = item;
            Projection = projection;
        }

        /// <summary>
        /// Деконструктор для AssociateResult.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="projection">Проекция элемента.</param>
        public void Deconstruct(out T item, out TOutput projection)
        {
            item = Item;
            projection = Projection;
        }

        /// <summary>
        /// Метод для преобразования в строку.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"[{Item.NilOrString()} - {Projection.NilOrString()}]";
        }
    }
}
