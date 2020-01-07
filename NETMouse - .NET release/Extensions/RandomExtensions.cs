using System;

namespace NETMouse.Extensions
{
    /// <summary>
    /// Provides standart extensions for Random.
    /// </summary>
    public static class RandomExtensions
    {
        /// <summary>
        /// Generates the number between two other numbers.
        /// </summary>
        /// <param name="random">The instance of Random.</param>
        /// <param name="low">The low border.</param>
        /// <param name="high">The high border.</param>
        /// <returns>The number generated between two other numbers.</returns>
        public static float Next(this Random random, float low, float high)
        {
            if (low > high)
                throw new ArgumentException("low");
            
            return low + (float)random.NextDouble() * (high - low);
        }
    }
}