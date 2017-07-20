using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Out.WriteLine("Original Text:");
            System.Console.Out.WriteLine(args[0]);
            System.Console.Out.WriteLine("Text Umbruch mit max. Zeilenlänge von " + args[1] + " Zeichen:");

            var dummy = Console.ReadLine();

        }
    }
}
