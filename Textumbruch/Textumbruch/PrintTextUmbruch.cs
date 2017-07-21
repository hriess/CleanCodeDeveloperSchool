using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    class PrintTextUmbruch
    {

        public void PrintTextMitUmbruch(String param1, String param2)
        {
            System.Console.Out.WriteLine("Original Text:");
            System.Console.Out.WriteLine(param1);
            System.Console.Out.WriteLine("Text Umbruch mit max. Zeilenlänge von " + param2 + " Zeichen:");
            TextUmbruch(param1, param2);
            Console.ReadLine();
        }

        public void TextUmbruch(String s, String p)
        {
            string[] words = s.Split(' ');
            int length = 0;
            foreach (string word in words)
            {
                Console.Write(word);
                Console.Write(" ");
                length = length + word.Length;
                if (length > int.Parse(p))
                {
                    Console.WriteLine("");
                    length = 0;
                }

            }
        }
    }
}
