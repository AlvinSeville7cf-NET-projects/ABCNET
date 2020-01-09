using System;

namespace ABCNETRUS
{
    public class АргументЯвляетсяNullОшибка : Exception
    {
        public АргументЯвляетсяNullОшибка(string message) : base(message)
        {
        }
    }

    public class АргументВнеДопустимогоДиапазонаОшибка : Exception
    {
        public АргументВнеДопустимогоДиапазонаОшибка(string message) : base(message)
        {
        }
    }

    public class НеверныйАргументОшибка : Exception
    {
        public НеверныйАргументОшибка(string message) : base(message)
        {
        }
    }
}
