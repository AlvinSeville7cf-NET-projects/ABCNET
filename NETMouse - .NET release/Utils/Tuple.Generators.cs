using System;

namespace ABCNET.Utils
{
    /// <summary>
    /// ������������� ���������� ��� ������ � ���������� ���������.
    /// </summary>
    public static partial class Tuple
    {
        #region public
        /// <summary>
        /// ������ ������ �� 2 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T2> Of<T, T2>(T item1, T2 item2)
        {
            return new Tuple<T, T2>(item1, item2);
        }

        /// <summary>
        /// ������ ������ �� 3 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        public static Tuple<T, T2, T3> Of<T,T2, T3>(T item1, T2 item2, T3 item3)
        {
            return new Tuple<T, T2, T3>(item1, item2, item3);
        }

        /// <summary>
        /// ������ ������ �� 4 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        public static Tuple<T, T2, T3, T4> Of<T, T2, T3, T4>(T item1, T2 item2, T3 item3, T4 item4)
        {
            return new Tuple<T, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// ������ ������ �� 5 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        /// <param name="item5">����� ��������.</param>
        public static Tuple<T, T2, T3, T4, T5> Of<T, T2, T3, T4, T5>(T item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new Tuple<T, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// ������ ������ �� 6 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        /// <param name="item5">����� ��������.</param>
        /// <param name="item6">������ ��������.</param>
        public static Tuple<T, T2, T3, T4, T5, T6> Of<T, T2, T3, T4, T5, T6>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new Tuple<T, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// ������ ������ �� 7 ��������.
        /// </summary>
        /// <param name="item1">������ ��������.</param>
        /// <param name="item2">������ ��������.</param>
        /// <param name="item3">������ ��������.</param>
        /// <param name="item4">�������� ��������.</param>
        /// <param name="item5">����� ��������.</param>
        /// <param name="item6">������ ��������.</param>
        /// <param name="item7">������� ��������.</param>
        public static Tuple<T, T2, T3, T4, T5, T6, T7> Of<T, T2, T3, T4, T5, T6, T7>(T item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new Tuple<T, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// ������ ������ �� 2 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T> By2<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1));
        }

        /// <summary>
        /// ������ ������ �� 3 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T> By3<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2));
        }

        /// <summary>
        /// ������ ������ �� 4 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T> By4<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3));
        }

        /// <summary>
        /// ������ ������ �� 5 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T> By5<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3), selector(firstIndex + 4));
        }

        /// <summary>
        /// ������ ������ �� 6 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T, T> By6<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3), selector(firstIndex + 4), selector(firstIndex + 5));
        }

        /// <summary>
        /// ������ ������ �� 7 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="selector">������� ��������.</param>
        /// <param name="firstIndex">��������� ������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T, T, T> By7<T>(Func<int, T> selector, int firstIndex = 0)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return Of(selector(firstIndex), selector(firstIndex + 1), selector(firstIndex + 2),
                selector(firstIndex + 3), selector(firstIndex + 4), selector(firstIndex + 5),
                selector(firstIndex + 6));
        }

        /// <summary>
        /// ������ ������ �� 2 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T> By2<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            return Of(a, b);
        }

        /// <summary>
        /// ������ ������ �� 3 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T> By3<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            return Of(a, b, c);
        }

        /// <summary>
        /// ������ ������ �� 4 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T> By4<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            return Of(a, b, c, d);
        }

        /// <summary>
        /// ������ ������ �� 5 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T> By5<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            var e = next(d);
            return Of(a, b, c, d, e);
        }

        /// <summary>
        /// ������ ������ �� 6 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T, T> By6<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            var e = next(d);
            var f = next(e);
            return Of(a, b, c, d, e, f);
        }

        /// <summary>
        /// ������ ������ �� 7 �������� �� ������ ������� ���������.
        /// </summary>
        /// <param name="first">������ �������.</param>
        /// <param name="next">������� ��������� ���������� ��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T, T, T> By7<T>(T first, Func<T, T> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));

            var a = first;
            var b = next(a);
            var c = next(b);
            var d = next(c);
            var e = next(d);
            var f = next(e);
            var g = next(f);
            return Of(a, b, c, d, e, f, g);
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int> Random2(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ��� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int, int> Random3(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ������ ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int, int, int> Random4(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int, int, int, int> Random5(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ����� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int, int, int, int, int> Random6(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Int32.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<int, int, int, int, int, int, int> Random7(int low = Int32BordersHelper.Low, int high = Int32BordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double> Random2(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ��� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double, double> Random3(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ������ ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double, double, double> Random4(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double, double, double, double> Random5(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ����� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double, double, double, double, double> Random6(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ��������� �������� ���� Double.
        /// </summary>
        /// <param name="low">������ ������� ���������.</param>
        /// <param name="high">������� ������� ���������.</param>
        /// <returns>������.</returns>
        public static Tuple<double, double, double, double, double, double, double> Random7(double low = DoubleBordersHelper.Low, double high = DoubleBordersHelper.High)
        {
            return Of(Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high), Base.Random(low, high));
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T> Fill2<T>(T value)
        {
            return Of(value, value);
        }

        /// <summary>
        /// ������ ������ �� ��� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T> Fill3<T>(T value)
        {
            return Of(value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ������ ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T> Fill4<T>(T value)
        {
            return Of(value, value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T> Fill5<T>(T value)
        {
            return Of(value, value, value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ����� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T, T> Fill6<T>(T value)
        {
            return Of(value, value, value, value, value, value);
        }

        /// <summary>
        /// ������ ������ �� ���� ���������, ����������� ��������� ���������.
        /// </summary>
        /// <param name="value">��������.</param>
        /// <returns>������.</returns>
        public static Tuple<T, T, T, T, T, T, T> Fill7<T>(T value)
        {
            return Of(value, value, value, value, value, value, value);
        }
        #endregion public
    }
}