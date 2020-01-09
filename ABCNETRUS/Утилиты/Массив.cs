using System;

namespace ABCNETRUS.”тилиты
{
    /// <summary>
    /// ѕредоставл€ет функционал дл€ работы с массивами.
    /// </summary>
    public static class ћассив
    {
        /// <summary>
        /// —оздаЄт массив из указанных значений.
        /// </summary>
        /// <param name="значени€">«начени€.</param>
        /// <returns>ћассив.</returns>
        public static T[] Ќовый<T>(params T[] значени€)
        {
            if (значени€ == null)
                throw new јргументявл€етс€Nullќшибка(nameof(значени€));

            return значени€;
        }

        /// <summary>
        /// —оздаЄт массив на основе функции селектора.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="отображение">‘ункци€ селектор.</param>
        /// <param name="первый»ндекс">Ќачальный индекс.</param>
        /// <returns>ћассив.</returns>
        public static T[] √енерировать<T>(int длина, Func<int, T> отображение, int первый»ндекс = 0)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));
            if (отображение == null)
                throw new јргументявл€етс€Nullќшибка(nameof(отображение));
            
            T[] source = new T[длина];
            for (int i = 0; i < source.Length; i++)
                source[i] = отображение(i + первый»ндекс);

            return source;
        }

        /// <summary>
        /// —оздаЄт массив на основе функции селектора.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="первый">ѕервый элемент.</param>
        /// <param name="отображение">‘ункци€ получени€ следующего элемента.</param>
        /// <returns>ћассив.</returns>
        public static T[] √енерировать<T>(int длина, T первый, Func<T, T> отображение)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));
            if (отображение == null)
                throw new јргументявл€етс€Nullќшибка(nameof(отображение));
            
            T[] source = new T[длина];
            source[0] = первый;
            for (int i = 1; i < source.Length; i++)
                source[i] = отображение(source[i - 1]);

            return source;
        }

        /// <summary>
        /// —оздаЄт массив случайных чисел типа Integer.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="нижн€€">Ќижн€€ граница диапазона.</param>
        /// <param name="верхн€€">¬ерхн€€ граница диапазона.</param>
        /// <returns>ћассив.</returns>
        public static int[] —лучайный(int длина, int нижн€€ = ÷елочисленные√раницы.Ќижн€€, int верхн€€ = ÷елочисленные√раницы.¬ерхн€€)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));
            if (нижн€€ > верхн€€)
                throw new Ќеверныйјргументќшибка(nameof(нижн€€));

            int[] source = new int[длина];
            for (int i = 0; i < source.Length; i++)
                source[i] = ќсновное.—лучайное(нижн€€, верхн€€);

            return source;
        }

        /// <summary>
        /// —оздаЄт массив случайных чисел типа Real.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="нижн€€">Ќижн€€ граница диапазона.</param>
        /// <param name="верхн€€">¬ерхн€€ граница диапазона.</param>
        /// <returns>ћассив.</returns>
        public static double[] —лучайный(int длина, double нижн€€ = ¬ещественные√раницы.Ќижн€€, double верхн€€ = ¬ещественные√раницы.¬ерхн€€)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));
            if (нижн€€ > верхн€€)
                throw new Ќеверныйјргументќшибка(nameof(нижн€€));

            double[] source = new double[длина];
            for (int i = 0; i < source.Length; i++)
                source[i] = ќсновное.—лучайное(нижн€€, верхн€€);

            return source;
        }

        /// <summary>
        /// —оздаЄт массив, заполненный указанным значением.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="значение">«начение.</param>
        /// <returns>ћассив.</returns>
        public static T[] «аполнить<T>(int длина, T значение)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));

            T[] source = new T[длина];
            for (int i = 0; i < source.Length; i++)
                source[i] = значение;

            return source;
        }

        /// <summary>
        /// „итает массив значений типа Boolean.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>ћассив.</returns>
        public static bool[] „итатьЋогический(int длина, string приглашение = ѕуста€—трока.«начение)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));

            bool[] array = new bool[длина];
            int i = 0;
            while (i < длина)
                try
                {
                    array[i] = ќсновное.„итатьЋогическое«начение(приглашение is null ? ѕуста€—трока.«начение : string.Format(приглашение, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(ќшибка¬вода.«начение);
                }

            return array;
        }

        /// <summary>
        /// „итает массив значений типа Char.
        /// </summary>
        /// <param name="count"> оличество элементов.</param>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>ћассив.</returns>
        public static char[] „итать—имвольный(int count, string приглашение = ѕуста€—трока.«начение)
        {
            if (count < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(count));

            char[] array = new char[count];
            for (int i = 0; i < count; i++)
                array[i] = ќсновное.„итать—имвол(приглашение is null ? ѕуста€—трока.«начение : string.Format(приглашение, i));

            return array;
        }

        /// <summary>
        /// „итает массив значений типа Real.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>ћассив.</returns>
        public static double[] „итать¬ещественный(int длина, string приглашение = ѕуста€—трока.«начение)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));

            double[] array = new double[длина];
            int i = 0;
            while (i < длина)
                try
                {
                    array[i] = ќсновное.„итать¬ещественное„исло(приглашение is null ? ѕуста€—трока.«начение : string.Format(приглашение, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(ќшибка¬вода.«начение);
                }

            return array;
        }

        /// <summary>
        /// „итает массив значений типа Integer.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="прииглашене">ѕриглашение к вводу.</param>
        /// <returns>ћассив.</returns>
        public static int[] „итать÷елочисленный(int длина, string прииглашене = ѕуста€—трока.«начение)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));

            int[] array = new int[длина];
            int i = 0;
            while (i < длина)
                try
                {
                    array[i] = ќсновное.„итать÷елое„исло(прииглашене is null ? ѕуста€—трока.«начение : string.Format(прииглашене, i));
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine(ќшибка¬вода.«начение);
                }

            return array;
        }

        /// <summary>
        /// „итает массив значений типа String.
        /// </summary>
        /// <param name="длина"> оличество элементов.</param>
        /// <param name="приглашение">ѕриглашение к вводу.</param>
        /// <returns>ћассив.</returns>
        public static string[] „итать—троковый(int длина, string приглашение = ѕуста€—трока.«начение)
        {
            if (длина < 0)
                throw new јргумент¬неƒопустимогоƒиапазонаќшибка(nameof(длина));

            string[] array = new string[длина];
            for (int i = 0; i < длина; i++)
                array[i] = ќсновное.„итать—троку(приглашение is null ? ѕуста€—трока.«начение : string.Format(приглашение, i));
            return array;
        }
    }
}