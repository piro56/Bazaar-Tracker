using System;
using System.Collections.Generic;
using System.Text;

namespace Bazaar_Console_Edition
{
    class ColorfulConsole
    {
        public static void writeGreen(string greenText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(greenText);
            Console.ResetColor();
        }

        public static void writeRed(string redText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(redText);
            Console.ResetColor();
        }

        public static void writeDarkRed(string darkRedText)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(darkRedText);
            Console.ResetColor();
        }

        public static void writeMagenta(string magentaText)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(magentaText);
            Console.ResetColor();
        }




    }
}
