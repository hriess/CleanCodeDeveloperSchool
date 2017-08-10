using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    class JavaMain
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("x");
            WordWrapJava01 x = new WordWrapJava01(int.Parse(args[1]));
            Console.Out.WriteLine(x.wrap(args[0]));
            Console.ReadLine();
        }
    }
}
