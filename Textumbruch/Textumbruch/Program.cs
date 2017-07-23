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
        private WordWrap wowa = new WordWrap();
        private WordWrapJava01 wowaJava01 = new WordWrapJava01();

        
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
                //p.Wrap(args[0], int.Parse(args[1]));
            }
        }

        private void PrintText(string[] args)
        {
            ptu.PrintTextMitUmbruch(args[0], args[1]);
            for (int i = int.Parse((args[1])) - 2; i <= int.Parse((args[1])); i++)
            {
                System.Console.Out.WriteLine("iteration: " + i + "\n");
                System.Console.Out.WriteLine(wowa.Wrap(args[0], i));
                System.Console.Out.WriteLine("---------------------------");
            }
            Console.ReadLine();
        }

        private void WrongNumberOfParameter(string[] args)
        {
            System.Console.Out.WriteLine(args.Length);
            System.Console.Out.WriteLine("Anzahl Parameter falsch (Text und Länge)");
            Console.ReadLine();
        }
    }
}
