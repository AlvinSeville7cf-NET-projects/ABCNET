using System;

namespace NETMouse
{
    internal static class ArrayHelper<T>
    {
        internal static T[] Empty { get; } = new T[0];
    }

    internal static class EmptyStringHelper
    {
        internal const string Empty = "";
    }

    internal static class InputErrorHelper
    {
        internal const string Message = "Неверный ввод. Введите элемент повторно.";
    }

    internal static class RandomHelper
    {
        internal static Random Random { get; } = new Random();
    }

    internal static class IntegerBordersHelper
    {
        internal const int Low = 0;
        internal const int High = int.MaxValue;
    }

    internal static class RealBordersHelper
    {
        internal const double Low = 0;
        internal const double High = double.MaxValue;
    }
}