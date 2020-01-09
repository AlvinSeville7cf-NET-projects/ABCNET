using System;

namespace ABCNETRUS
{
    internal static class ArrayHelper<T>
    {
        internal static T[] Empty { get; } = new T[0];
    }

    internal static class ПустаяСтрока
    {
        internal const string Значение = "";
    }

    internal static class ОшибкаВвода
    {
        internal const string Значение = "Неверный ввод. Введите элемент повторно.";
    }

    internal static class УстаревшийФункционал
    {
        internal const string Значение = "Данный функционал оставлен лишь для обратной совместимости с PABCSystem и не рекомендуется к использованию на платформе NET.";
    }

    internal static class Разделитель
    {
        internal const string Значение = " ";
    }

    internal static class ДатчикПсевдослучайныхЧисел
    {
        internal static Random Значение { get; } = new Random();
    }

    internal static class ЦелочисленныеГраницы
    {
        internal const int Нижняя = 0;
        internal const int Верхняя = int.MaxValue;
    }

    internal static class ВещественныеГраницы
    {
        internal const double Нижняя = 0;
        internal const double Верхняя = double.MaxValue;
    }
}