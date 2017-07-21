using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    class Program
    {
        private PrintTextUmbruch ptu = new PrintTextUmbruch();
        
        static void Main(string[] args)
        {
            var p = new Program();

            if (args.Length != 2)
            {
                p.WrongNumberOfParameter(args);
            }
            else
            {
                p.PrintText(args);
            }
        }

        private void PrintText(string[] args)
        {
            ptu.PrintTextMitUmbruch(args[0], args[1]);
        }

        private void WrongNumberOfParameter(string[] args)
        {
            System.Console.Out.WriteLine(args.Length);
            System.Console.Out.WriteLine("Anzahl Parameter falsch (Text und Länge)");
            Console.ReadLine();
        }
    }
}
