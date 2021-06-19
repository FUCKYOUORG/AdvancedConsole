using System;
using System.Collections.Generic;
namespace AdvancedConsole
{
    public delegate void KeyEventHandler(AdvancedConsole context, ConsoleKeyInfo k);
    public delegate void InputEventHandler(AdvancedConsole context, string s);
    public delegate void Something(AdvancedConsole context);
    public class AdvancedConsole
    {
        private Stack<ConsoleColors> m_historyColors;
        public AdvancedConsole()
        {
            m_historyColors = new Stack<ConsoleColors>();
        }
        public AdvancedConsole SetBackground(ConsoleColor back)
        {
            m_historyColors.Push(new ConsoleColors());
            Console.BackgroundColor = back;
            return this;
        }
        public AdvancedConsole SetForeground(ConsoleColor fore)
        {
            m_historyColors.Push(new ConsoleColors());
            Console.ForegroundColor = fore;
            return this;
        }
        public AdvancedConsole RestoreColors()
        {
            m_historyColors.Pop().Apply();
            return this;
        }
        public AdvancedConsole RestoreBack()
        {
            m_historyColors.Pop().ApplyBackgroundColor();
            return this;
        }
        public AdvancedConsole RestoreFore()
        {
            m_historyColors.Pop().ApplyForegroundCOlor();
            return this;
        }
        public AdvancedConsole Out(object any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(string any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(int any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(long any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(float any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(double any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(char any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(byte any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole Out(bool any)
        {
            Console.Write(any);
            return this;
        }
        public AdvancedConsole In(InputEventHandler handler)
        {
            handler(this, Console.ReadLine());
            return this;
        }
        public AdvancedConsole WaitForKey(ConsoleKey key)
        {
            while (Console.ReadKey(true).Key != key) ;
            return this;
        }
        public AdvancedConsole WaitForKey(KeyEventHandler handler)
        {
            handler(this, Console.ReadKey(true));
            return this;
        }
        public AdvancedConsole MoveCursorTo(int x, int y)
        {
            Console.CursorTop = y;
            Console.CursorLeft = x;
            return this;
        }
        public AdvancedConsole CursorSize(int s)
        {
            Console.CursorSize = s;
            return this;
        }
        public AdvancedConsole HideCursor()
        {
            Console.CursorVisible = false;
            return this;
        }
        public AdvancedConsole ShowCursor()
        {
            Console.CursorVisible = true;
            return this;
        }
        public AdvancedConsole ToggleCursorVisible()
        {
            Console.CursorVisible = !Console.CursorVisible;
            return this;
        }
        public AdvancedConsole EndLine()
        {
            Console.WriteLine();
            return this;
        }
        public AdvancedConsole Execute(Something fun)
        {
            fun(this);
            return this;
        }
        public AdvancedConsole Outf(string s, params object[] cons)
        {
            Console.Write(s, cons);
            return this;
        }
        public AdvancedConsole Clear()
        {
            Console.Clear();
            return this;
        }
    }
}
