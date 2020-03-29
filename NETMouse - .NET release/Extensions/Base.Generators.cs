using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class BaseExt
    {
        #region public
        /// <summary>
        /// Создаёт последовательность от начального числа до конечного.
        /// </summary>
        /// <param name="from">Начальное число.</param>
        /// <param name="to">Конечное число.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> To(this int from, int to)
        {
            if (from >= to)
                for (int i = from; i >= to; i--)
                    yield return i;
            else
                for (int i = from; i <= to; i++)
                    yield return i;
        }

        /// <summary>
        /// Создаёт последовательность от 0 до конечного числа.
        /// </summary>
        /// <param name="to">Конечное число.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> Times(this int to)
        {
            if (to < 0)
                return 0.To(to);
            return 0.To(to);
        }

        /// <summary>
        /// Создаёт бесконечную последовательность от начального числа.
        /// </summary>
        /// <param name="from">Начальное число.</param>
        /// <param name="step">Шаг.</param>
        /// <returns>Последовательность.</returns>
        public static IEnumerable<int> Step(this int from, int step)
        {
            do
            {
                yield return from;
                from += step;
            } while (true);
        }
        #endregion public
    }
}
