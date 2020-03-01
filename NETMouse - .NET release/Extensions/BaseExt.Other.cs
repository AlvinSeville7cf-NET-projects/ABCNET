namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class BaseExt
    {

        #region public

        /// <summary>
        /// Проверяет лежит ли число между другими двумя.
        /// </summary>
        /// <param name="target">Число.</param>
        /// <param name="firstBorder">Первая граница.</param>
        /// <param name="secondBorder">Вторая граница.</param>
        /// <returns>Результат.</returns>
        public static bool IsBetween(this int target, int firstBorder, int secondBorder)
        {
            if (firstBorder > secondBorder)
                Utils.Base.Swap(ref firstBorder, ref secondBorder);
            return (target >= firstBorder) && (target <= secondBorder);
        }

        #endregion

    }
}
