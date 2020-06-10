namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class BaseE
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
                return (target >= secondBorder) && (target <= firstBorder);
            return (target >= firstBorder) && (target <= secondBorder);
        }

        /// <summary>
        /// Проверяет лежит ли число между другими двумя.
        /// </summary>
        /// <param name="target">Число.</param>
        /// <param name="firstBorder">Первая граница.</param>
        /// <param name="secondBorder">Вторая граница.</param>
        /// <returns>Результат.</returns>
        public static bool IsBetween(this int target, int firstBorder, bool equalsFirst, int secondBorder, bool equalsSecond)
        {
            if (firstBorder > secondBorder)
                return (target > secondBorder || (equalsSecond && target == secondBorder)) && (target < firstBorder || (equalsFirst && target == firstBorder));
            return (target > firstBorder || (equalsFirst && target == firstBorder)) && (target < secondBorder || (equalsSecond && target == secondBorder));
        }

        #endregion public

    }
}
