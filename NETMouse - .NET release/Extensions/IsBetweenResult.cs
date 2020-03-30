using System;
using System.Collections.Generic;

namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для IsBetween.
    /// </summary>
    public class IsBetweenResult
    {
        /// <summary>
        /// Аргументы.
        /// </summary>
        public List<int> Arguments { get; }

        /// <summary>
        /// Диапазон.
        /// </summary>
        public IntRange Range { get; }

        /// <summary>
        /// Конструктор для IsBetweenResult.
        /// </summary>
        /// <param name="item">Аргументы.</param>
        /// <param name="projection">Диапазон.</param>
        public IsBetweenResult(List<int> arguments, IntRange range)
        {
            if (arguments is null)
                throw new ArgumentNullException(nameof(arguments));

            Arguments = arguments;
            Range = range;
        }
    }
}
