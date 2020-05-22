using System;
using System.Numerics;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class Base
    {
        /// <summary>
        /// Предоставляет функционал для работы с Nullable типами.
        /// </summary>
        public static partial class Nullable
        {

            #region public

            #region ReadBoolean?

            /// <summary>
            /// Читает кортеж из двух значений типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?, bool?> ReadBooleanTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBoolean(string.Format(prompt, 0)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?, bool?, bool?> ReadBooleanTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBoolean(string.Format(prompt, 0)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 1)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?, bool?, bool?, bool?> ReadBooleanTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBoolean(string.Format(prompt, 0)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 1)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 2)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?, bool?, bool?, bool?, bool?> ReadBooleanTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBoolean(string.Format(prompt, 0)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 1)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 2)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 3)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?, bool?, bool?, bool?, bool?, bool?> ReadBooleanTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBoolean(string.Format(prompt, 0)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 1)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 2)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 3)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 4)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Boolean?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<bool?, bool?, bool?, bool?, bool?, bool?, bool?> ReadBooleanTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBoolean(string.Format(prompt, 0)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 1)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 2)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 3)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 4)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 5)),
                                Base.Nullable.ReadBoolean(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadByte?

            /// <summary>
            /// Читает кортеж из двух значений типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?, byte?> ReadByteTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadByte(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?, byte?, byte?> ReadByteTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadByte(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?, byte?, byte?, byte?> ReadByteTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadByte(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?, byte?, byte?, byte?, byte?> ReadByteTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadByte(string.Format(prompt, 3)),
                                Base.Nullable.ReadByte(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?, byte?, byte?, byte?, byte?, byte?> ReadByteTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadByte(string.Format(prompt, 3)),
                                Base.Nullable.ReadByte(string.Format(prompt, 4)),
                                Base.Nullable.ReadByte(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Byte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<byte?, byte?, byte?, byte?, byte?, byte?, byte?> ReadByteTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadByte(string.Format(prompt, 3)),
                                Base.Nullable.ReadByte(string.Format(prompt, 4)),
                                Base.Nullable.ReadByte(string.Format(prompt, 5)),
                                Base.Nullable.ReadByte(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadSByte?

            /// <summary>
            /// Читает кортеж из двух значений типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?, sbyte?> ReadSByteTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?, sbyte?, sbyte?> ReadSByteTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?, sbyte?, sbyte?, sbyte?> ReadSByteTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?, sbyte?, sbyte?, sbyte?, sbyte?> ReadSByteTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 3)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?, sbyte?, sbyte?, sbyte?, sbyte?, sbyte?> ReadSByteTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 3)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 4)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа SByte?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<sbyte?, sbyte?, sbyte?, sbyte?, sbyte?, sbyte?, sbyte?> ReadSByteTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSByte(string.Format(prompt, 0)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 1)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 2)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 3)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 4)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 5)),
                                Base.Nullable.ReadSByte(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadChar?

            /// <summary>
            /// Читает кортеж из двух значений типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?, char?> ReadCharTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadChar(string.Format(prompt, 0)),
                                Base.Nullable.ReadChar(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?, char?, char?> ReadCharTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadChar(string.Format(prompt, 0)),
                                Base.Nullable.ReadChar(string.Format(prompt, 1)),
                                Base.Nullable.ReadChar(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?, char?, char?, char?> ReadCharTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadChar(string.Format(prompt, 0)),
                                Base.Nullable.ReadChar(string.Format(prompt, 1)),
                                Base.Nullable.ReadChar(string.Format(prompt, 2)),
                                Base.Nullable.ReadChar(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?, char?, char?, char?, char?> ReadCharTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadChar(string.Format(prompt, 0)),
                                Base.Nullable.ReadChar(string.Format(prompt, 1)),
                                Base.Nullable.ReadChar(string.Format(prompt, 2)),
                                Base.Nullable.ReadChar(string.Format(prompt, 3)),
                                Base.Nullable.ReadChar(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?, char?, char?, char?, char?, char?> ReadCharTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadChar(string.Format(prompt, 0)),
                                Base.Nullable.ReadChar(string.Format(prompt, 1)),
                                Base.Nullable.ReadChar(string.Format(prompt, 2)),
                                Base.Nullable.ReadChar(string.Format(prompt, 3)),
                                Base.Nullable.ReadChar(string.Format(prompt, 4)),
                                Base.Nullable.ReadChar(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Char?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<char?, char?, char?, char?, char?, char?, char?> ReadCharTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadChar(string.Format(prompt, 0)),
                                Base.Nullable.ReadChar(string.Format(prompt, 1)),
                                Base.Nullable.ReadChar(string.Format(prompt, 2)),
                                Base.Nullable.ReadChar(string.Format(prompt, 3)),
                                Base.Nullable.ReadChar(string.Format(prompt, 4)),
                                Base.Nullable.ReadChar(string.Format(prompt, 5)),
                                Base.Nullable.ReadChar(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadDecimal?

            /// <summary>
            /// Читает кортеж из двух значений типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?, decimal?> ReadDecimalTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDecimal(string.Format(prompt, 0)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?, decimal?, decimal?> ReadDecimalTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDecimal(string.Format(prompt, 0)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 1)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?, decimal?, decimal?, decimal?> ReadDecimalTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDecimal(string.Format(prompt, 0)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 1)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 2)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?, decimal?, decimal?, decimal?, decimal?> ReadDecimalTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDecimal(string.Format(prompt, 0)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 1)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 2)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 3)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?, decimal?, decimal?, decimal?, decimal?, decimal?> ReadDecimalTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDecimal(string.Format(prompt, 0)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 1)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 2)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 3)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 4)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Decimal?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<decimal?, decimal?, decimal?, decimal?, decimal?, decimal?, decimal?> ReadDecimalTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDecimal(string.Format(prompt, 0)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 1)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 2)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 3)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 4)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 5)),
                                Base.Nullable.ReadDecimal(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadDouble?

            /// <summary>
            /// Читает кортеж из двух значений типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?, double?> ReadDoubleTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDouble(string.Format(prompt, 0)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?, double?, double?> ReadDoubleTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDouble(string.Format(prompt, 0)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 1)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?, double?, double?, double?> ReadDoubleTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDouble(string.Format(prompt, 0)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 1)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 2)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?, double?, double?, double?, double?> ReadDoubleTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDouble(string.Format(prompt, 0)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 1)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 2)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 3)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?, double?, double?, double?, double?, double?> ReadDoubleTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDouble(string.Format(prompt, 0)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 1)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 2)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 3)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 4)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Double?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<double?, double?, double?, double?, double?, double?, double?> ReadDoubleTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadDouble(string.Format(prompt, 0)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 1)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 2)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 3)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 4)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 5)),
                                Base.Nullable.ReadDouble(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadSingle?

            /// <summary>
            /// Читает кортеж из двух значений типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?, float?> ReadSingleTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSingle(string.Format(prompt, 0)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?, float?, float?> ReadSingleTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSingle(string.Format(prompt, 0)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 1)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?, float?, float?, float?> ReadSingleTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSingle(string.Format(prompt, 0)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 1)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 2)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?, float?, float?, float?, float?> ReadSingleTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSingle(string.Format(prompt, 0)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 1)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 2)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 3)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?, float?, float?, float?, float?, float?> ReadSingleTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSingle(string.Format(prompt, 0)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 1)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 2)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 3)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 4)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Single?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<float?, float?, float?, float?, float?, float?, float?> ReadSingleTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadSingle(string.Format(prompt, 0)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 1)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 2)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 3)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 4)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 5)),
                                Base.Nullable.ReadSingle(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadInt32?

            /// <summary>
            /// Читает кортеж из двух значений типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?, int?> ReadInt32Tuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?, int?, int?> ReadInt32Tuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?, int?, int?, int?> ReadInt32Tuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?, int?, int?, int?, int?> ReadInt32Tuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?, int?, int?, int?, int?, int?> ReadInt32Tuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 4)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Int32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<int?, int?, int?, int?, int?, int?, int?> ReadInt32Tuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 4)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 5)),
                                Base.Nullable.ReadInt32(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadUInt32?

            /// <summary>
            /// Читает кортеж из двух значений типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?, uint?> ReadUInt32Tuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?, uint?, uint?> ReadUInt32Tuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?, uint?, uint?, uint?> ReadUInt32Tuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?, uint?, uint?, uint?, uint?> ReadUInt32Tuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?, uint?, uint?, uint?, uint?, uint?> ReadUInt32Tuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 4)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа UInt32?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<uint?, uint?, uint?, uint?, uint?, uint?, uint?> ReadUInt32Tuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt32(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 4)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 5)),
                                Base.Nullable.ReadUInt32(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadInt64?

            /// <summary>
            /// Читает кортеж из двух значений типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?, long?> ReadInt64Tuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?, long?, long?> ReadInt64Tuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?, long?, long?, long?> ReadInt64Tuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?, long?, long?, long?, long?> ReadInt64Tuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?, long?, long?, long?, long?, long?> ReadInt64Tuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 4)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Int64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<long?, long?, long?, long?, long?, long?, long?> ReadInt64Tuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 4)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 5)),
                                Base.Nullable.ReadInt64(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadUInt64?

            /// <summary>
            /// Читает кортеж из двух значений типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?, ulong?> ReadUInt64Tuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?, ulong?, ulong?> ReadUInt64Tuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?, ulong?, ulong?, ulong?> ReadUInt64Tuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?, ulong?, ulong?, ulong?, ulong?> ReadUInt64Tuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?, ulong?, ulong?, ulong?, ulong?, ulong?> ReadUInt64Tuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 4)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа UInt64?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ulong?, ulong?, ulong?, ulong?, ulong?, ulong?, ulong?> ReadUInt64Tuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt64(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 4)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 5)),
                                Base.Nullable.ReadUInt64(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadInt16?

            /// <summary>
            /// Читает кортеж из двух значений типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?, short?> ReadInt16Tuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?, short?, short?> ReadInt16Tuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?, short?, short?, short?> ReadInt16Tuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?, short?, short?, short?, short?> ReadInt16Tuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?, short?, short?, short?, short?, short?> ReadInt16Tuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 4)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа Int16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<short?, short?, short?, short?, short?, short?, short?> ReadInt16Tuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 3)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 4)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 5)),
                                Base.Nullable.ReadInt16(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadUInt16?

            /// <summary>
            /// Читает кортеж из двух значений типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?, ushort?> ReadUInt16Tuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?, ushort?, ushort?> ReadUInt16Tuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?, ushort?, ushort?, ushort?> ReadUInt16Tuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?, ushort?, ushort?, ushort?, ushort?> ReadUInt16Tuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?, ushort?, ushort?, ushort?, ushort?, ushort?> ReadUInt16Tuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 4)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа UInt16?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<ushort?, ushort?, ushort?, ushort?, ushort?, ushort?, ushort?> ReadUInt16Tuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadUInt16(string.Format(prompt, 0)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 1)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 2)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 3)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 4)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 5)),
                                Base.Nullable.ReadUInt16(string.Format(prompt, 6)));
            }

            #endregion
            
            #region ReadBigInteger?

            /// <summary>
            /// Читает кортеж из двух значений типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?, BigInteger?> ReadBigIntegerTuple2(string prompt = null)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBigInteger(string.Format(prompt, 0)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 1)));
            }

            /// <summary>
            /// Читает кортеж из трёх значений типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?, BigInteger?, BigInteger?> ReadBigIntegerTuple3(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBigInteger(string.Format(prompt, 0)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 1)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 2)));
            }

            /// <summary>
            /// Читает кортеж из четырёх значений типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?, BigInteger?, BigInteger?, BigInteger?> ReadBigIntegerTuple4(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBigInteger(string.Format(prompt, 0)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 1)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 2)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 3)));
            }

            /// <summary>
            /// Читает кортеж из пяти значений типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?, BigInteger?, BigInteger?, BigInteger?, BigInteger?> ReadBigIntegerTuple5(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBigInteger(string.Format(prompt, 0)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 1)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 2)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 3)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 4)));
            }

            /// <summary>
            /// Читает кортеж из шести значений типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?, BigInteger?, BigInteger?, BigInteger?, BigInteger?, BigInteger?> ReadBigIntegerTuple6(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBigInteger(string.Format(prompt, 0)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 1)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 2)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 3)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 4)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 5)));
            }

            /// <summary>
            /// Читает кортеж из семи значений типа BigInteger?. [Не работает при запуске из под оболочки в IDE PascalABC.NET.]
            /// </summary>
            /// <returns>Кортеж.</returns>
            public static Tuple<BigInteger?, BigInteger?, BigInteger?, BigInteger?, BigInteger?, BigInteger?, BigInteger?> ReadBigIntegerTuple7(string prompt = EmptyStringHelper.Empty)
            {
                prompt = prompt ?? EmptyStringHelper.Empty;

                return Tuple.Of(Base.Nullable.ReadBigInteger(string.Format(prompt, 0)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 1)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 2)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 3)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 4)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 5)),
                                Base.Nullable.ReadBigInteger(string.Format(prompt, 6)));
            }

            #endregion

            #endregion

        }
    }
}
