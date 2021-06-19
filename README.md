# AdvancedConsole
The testing code tells you how to use the library.

```C#
using System;

namespace AdvancedConsoleUnitTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var console = new AdvancedConsole.AdvancedConsole();
            string inR = "";
            console
                .Outf("Hello, {0}!", "World")
                .Out("\nTry input something: ")
                .In((context, s) =>
                {
                    inR = s;
                })
                .SetForeground(ConsoleColor.Red)
                .Out(inR)
                .SetForeground(ConsoleColor.Green)
                .RestoreColors()
                .EndLine()
                .Execute((context) =>
                {
                    inR = "Changed! (LOL)";
                })
                .Outf("Again, now inR = {0}\n", inR)
                .Out("Bye!");
        }
    }
}
```
