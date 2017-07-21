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
            string tmpWord = "";
            string tmpWordOverHead = "";
            foreach (string word in words)
            {
                tmpWord += word + " ";
                tmpWord = CheckWordFit(tmpWord, p);
                tmpWordOverHead = CheckWordOverHead(tmpWord, p);

                length += tmpWord.Length;
                if (length >= int.Parse(p))
                {
                    Console.WriteLine(tmpWord.Substring(0,int.Parse(p)));
                    length = 0;
                    tmpWord = tmpWord.Substring(int.Parse(p));
                }

            }
        }

        private String CheckWordFit(String s, String p)
        {
            if (s.Length > int.Parse(p))
            {
                return s.Substring(0, int.Parse(p));
            }
            else
            {
                return s;
            }
            
        }

        private String CheckWordOverHead(String s, String p)
        {
            if (s.Length > int.Parse(p))
            {
                return s.Substring(int.Parse(p),s.Length- int.Parse(p));
            }
            else
            {
                return "";
            }

        }
    }
}
