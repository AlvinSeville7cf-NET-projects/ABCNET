namespace ABCNET.Utils
{
    /// <summary>
    /// Предоставляет функционал для работы с базовыми типами.
    /// </summary>
    public static partial class BaseU
    {

        #region public

        /// <summary>
        /// Меняет местами значения двух переменных.
        /// </summary>
        /// <param name="x">Первая переменная.</param>
        /// <param name="y">Вторая переменная.</param>
        public static void Swap<T>(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }

        #endregion public
    
    }
}
