using System;
using System.Text;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Provides standart extensions for StringBuilder.
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Prints the instance of StringBuilder.
        /// </summary>
        /// <param name="stringBuilder">The instance of StringBuilder.</param>
        /// <returns>The current instance of StringBuilder.</returns>
        public static StringBuilder Print(this StringBuilder stringBuilder)
        {
            Console.Write(stringBuilder);
            return stringBuilder;
        }
        
        /// <summary>
        /// Prints the instance of StringBuilder and jumps onto the new line.
        /// </summary>
        /// <param name="stringBuilder">The instance of StringBuilder.</param>
        /// <returns>The current instance of StringBuilder.</returns>
        public static StringBuilder PrintLine(this StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
            return stringBuilder;
        }
    }
}