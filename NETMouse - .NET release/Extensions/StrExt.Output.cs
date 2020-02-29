using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABCNET.Extensions
{
    public static partial class Str
    {

        #region Public

        /// <summary>
        /// Выводит строку на экран.
        /// </summary>
        /// <param name="input">Строка.</param>
        /// <returns>Строка.</returns>
        public static string Print(this string input)
        {
            Console.Write(input.NilOrString());
            return input;
        }

        /// <summary>
        /// Выводит строку на экран и переходит на следующую строку.
        /// </summary>
        /// <param name="input">Строка.</param>
        /// <returns>Строка.</returns>
        public static string Println(this string input)
        {
            Console.WriteLine(input.NilOrString());
            return input;
        }

        #endregion

    }
}
