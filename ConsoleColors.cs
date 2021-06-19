using System;
namespace AdvancedConsole
{
    public class ConsoleColors
    {
        private ConsoleColor m_fore;
        private ConsoleColor m_back;
        public ConsoleColors(ConsoleColor fore, ConsoleColor back)
        {
            m_fore = fore;
            m_back = back;
        }
        public ConsoleColors(ConsoleColor fore)
        {
            m_fore = fore;
            m_back = Console.BackgroundColor;
        }
        public ConsoleColors()
        {
            m_fore = Console.ForegroundColor;
            m_back = Console.BackgroundColor;
        }
        public void Apply()
        {
            Console.ForegroundColor = m_fore;
            Console.BackgroundColor = m_back;
        }
        public void ApplyBackgroundColor()
        {
            Console.BackgroundColor = m_back;
        }
        public void ApplyForegroundCOlor()
        {
            Console.ForegroundColor = m_fore;
        }
        public static ConsoleColors InitWithBackgroundColor(ConsoleColor back)
        {
            return new ConsoleColors(Console.ForegroundColor, back);
        }
        public static ConsoleColors InitWithForegroundColor(ConsoleColor fore)
        {
            return new ConsoleColors(fore);
        }
    }
}
