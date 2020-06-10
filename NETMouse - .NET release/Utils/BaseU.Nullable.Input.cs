using System.Numerics;
using ABCNET.Extensions;

namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class BaseU
    {
        /// <summary>
        /// Предоставляет функционал для работы с Nullable типами.
        /// </summary>
        public static partial class Nullable
        {

            #region public

            /// <summary>
            /// Читает значение типа Boolean?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static bool? ReadBoolean(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                bool result = default;
                while ((resultString != NilStringHelper.Nil) && !bool.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new bool?(result);
            }

            /// <summary>
            /// Читает значение типа Byte?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static byte? ReadByte(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                byte result = default;
                while ((resultString != NilStringHelper.Nil) && !byte.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new byte?(result);
            }

            /// <summary>
            /// Читает значение типа SByte?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static sbyte? ReadSByte(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                sbyte result = default;
                while ((resultString != NilStringHelper.Nil) && !sbyte.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new sbyte?(result);
            }

            /// <summary>
            /// Читает значение типа Char?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static char? ReadChar(string prompt = EmptyStringHelper.Empty)
            {
                string result = InternalReadTrimmedString(prompt);
                return result == NilStringHelper.Nil ? null : new char?(char.Parse(result));
            }

            /// <summary>
            /// Читает значение типа Decimal?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static decimal? ReadDecimal(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                decimal result = default;
                while ((resultString != NilStringHelper.Nil) && !decimal.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new decimal?(result);
            }

            /// <summary>
            /// Читает значение типа Double?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static double? ReadDouble(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                double result = default;
                while ((resultString != NilStringHelper.Nil) && !double.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new double?(result);
            }

            /// <summary>
            /// Читает значение типа Single?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static float? ReadSingle(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                float result = default;
                while ((resultString != NilStringHelper.Nil) && !float.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new float?(result);
            }

            /// <summary>
            /// Читает значение типа Int32?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static int? ReadInt32(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                int result = default;
                while ((resultString != NilStringHelper.Nil) && !int.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new int?(result);
            }

            /// <summary>
            /// Читает значение типа UInt32?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static uint? ReadUInt32(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                uint result = default;
                while ((resultString != NilStringHelper.Nil) && !uint.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new uint?(result);
            }

            /// <summary>
            /// Читает значение типа Int64?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static long? ReadInt64(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                long result = default;
                while ((resultString != NilStringHelper.Nil) && !long.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new long?(result);
            }

            /// <summary>
            /// Читает значение типа UInt64?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static ulong? ReadUInt64(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                ulong result = default;
                while ((resultString != NilStringHelper.Nil) && !ulong.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new ulong?(result);
            }

            /// <summary>
            /// Читает значение типа Int16?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static short? ReadInt16(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                short result = default;
                while ((resultString != NilStringHelper.Nil) && !short.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new short?(result);
            }

            /// <summary>
            /// Читает значение типа UInt16?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static ushort? ReadUInt16(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                ushort result = default;
                while ((resultString != NilStringHelper.Nil) && !ushort.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new ushort?(result);
            }

            /// <summary>
            /// Читает значение типа BigInteger?.
            /// </summary>
            /// <param name="prompt">Приглашение к вводу.</param>
            /// <returns>Значение.</returns>
            public static BigInteger? ReadBigInteger(string prompt = EmptyStringHelper.Empty)
            {
                string resultString = InternalReadTrimmedString(prompt);

                BigInteger result = default;
                while ((resultString != NilStringHelper.Nil) && !BigInteger.TryParse(resultString, out result))
                {
                    InputErrorHelper.Message.PrintLine();
                    resultString = InternalReadTrimmedString(prompt);
                }

                return resultString == NilStringHelper.Nil ? null : new BigInteger?(result);
            }

            #endregion public

            #region private

            private static string InternalReadTrimmedString(string prompt)
            {
                return ReadString(prompt).Trim().ToLower();
            }

            #endregion private

        }
    }
}
