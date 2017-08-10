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
            
            for (int i = 20; i < 26; i += 5)
            {
               Console.Out.WriteLine(i + " ---------------------");
               //WordWrapJava01 x = new WordWrapJava01(int.Parse(args[1]));
               WordWrapJava01 x = new WordWrapJava01(i);
                
                WordWrapJava01 y = new WordWrapJava01("     ","\n",i);
                Console.Out.WriteLine(x.wrap(args[0]));
                Console.Out.WriteLine(i + " Blank ---------------------");
                Console.Out.WriteLine(y.wrap(args[0]));
                Console.Out.WriteLine(WordWrapJava01.wrap(x.wrap(args[0]), i));
            }
            Console.ReadLine();

        }
    }
}
