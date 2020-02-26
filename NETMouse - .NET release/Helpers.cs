using System;

namespace ABCNET
{
    internal static class ArrayHelper<T>
    {
        internal static T[] Empty { get; } = new T[0];
    }

    internal static class NilStringHelper
    {
        internal const string Nil = "nil";
    }

    internal static class EmptyStringHelper
    {
        internal const string Empty = "";
    }

    internal static class InputErrorHelper
    {
        internal const string Message = "Неверный ввод. Введите элемент повторно.";
    }

    internal static class DefaultDelimiterHelper
    {
        internal const string Delimiter = " ";
    }

    internal static class RandomHelper
    {
        internal static Random Random { get; } = new Random();
    }

    internal static class Int32BordersHelper
    {
        internal const int Low = 0;
        internal const int High = int.MaxValue - 1;
    }

    internal static class DoubleBordersHelper
    {
        internal const double Low = 0;
        internal const double High = double.MaxValue;
    }

    internal static class ObjExt
    {
        internal static string NilOrString<T>(this T item)
        {
            return item == null ? NilStringHelper.Nil : item.ToString();
        }
    }
}