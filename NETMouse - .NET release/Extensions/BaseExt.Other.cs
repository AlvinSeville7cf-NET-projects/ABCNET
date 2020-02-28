using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCNET.Extensions
{
    public static partial class BaseExt
    {
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
    }
}
