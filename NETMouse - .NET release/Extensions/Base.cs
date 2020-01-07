using System;
using System.Collections.Generic;
using System.Linq;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static class Base
    {
        /// <summary>
        /// Indicates whether the value is in the particular range.
        /// </summary>
        /// <param name="target">The value.</param>
        /// <param name="firstBorder">The first border of the range.</param>
        /// <param name="secondBorder">The second border of the range.</param>
        /// <returns>The evaluation result.</returns>
        public static bool IsBetween(this int target, int firstBorder, int secondBorder)
        {
            if (firstBorder > secondBorder)
                Utils.Base.Swap(ref firstBorder, ref secondBorder);
            return (target >= firstBorder) && (target <= secondBorder);
        }
        
        /// <summary>
        /// Returns the sequence from the first value to the second value.
        /// </summary>
        /// <param name="from">The first value.</param>
        /// <param name="to">The second value.</param>
        /// <returns>The sequence from the first value to the second value.</returns>
        public static IEnumerable<int> To(this int from, int to)
        {
            if (from > to)
                return Enumerable.Empty<int>();
            return Enumerable.Range(from, to - from + 1);
        }

        /// <summary>
        /// Returns the sequence from the first value to the second value.
        /// </summary>
        /// <param name="from">The first value.</param>
        /// <param name="to">The second value.</param>
        /// <returns>The sequence from the first value to the second value.</returns>
        public static IEnumerable<int> DownTo(this int from, int to)
        {
            if (from < to)
            {
                foreach (var item in Enumerable.Empty<int>())
                    yield return item;
                yield break;
            }
            
            for (int i = from; i >= to; i--)
                yield return i;
        }
        
        /// <summary>
        /// Returns the sequence from 0 to the last value.
        /// </summary>
        /// <param name="to">The last value.</param>
        /// <returns>The sequence from 0 to the last value.</returns>
        public static IEnumerable<int> Times(this int to)
        {
            if (to < 0)
                return 0.DownTo(to);
            return 0.To(to);
        }

        /// <summary>
        /// Returns the stepped sequence from the particular value.
        /// </summary>
        /// <param name="from">The first item.</param>
        /// <param name="step">The step.</param>
        /// <returns>The stepped sequence.</returns>
        public static IEnumerable<int> Step(this int from, int step)
        {
            do
            {
                yield return from;
                from += step;
            } while (true);
        }

        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static bool Print(this bool item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static bool Println(this bool item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static char Print(this char item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static char Println(this char item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static decimal Print(this decimal item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static decimal Println(this decimal item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static double Print(this double item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static double Println(this double item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static float Print(this float item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static float Println(this float item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static int Print(this int item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static int Println(this int item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static uint Print(this uint item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static uint Println(this uint item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static long Print(this long item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static long Println(this long item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static ulong Print(this ulong item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static ulong Println(this ulong item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static short Print(this short item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static short Println(this short item)
        {
            Console.WriteLine(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static ushort Print(this ushort item)
        {
            Console.Write(item);
            return item;
        }
        
        /// <summary>
        /// Prints the singular value and jumps onto the new line.
        /// </summary>
        /// <param name="item">The value.</param>
        /// <returns>The value.</returns>
        public static ushort Println(this ushort item)
        {
            Console.WriteLine(item);
            return item;
        }
    }
}