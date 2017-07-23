using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    public class WordWrap
    {
        private const string SWhiteSpace = " ";
        private const string SNewLine = "\n";

        public string Wrap(string text, int length)
        {
            return string.Join(string.Empty,
                Wrap(text.Split(new[] { SWhiteSpace }, StringSplitOptions.RemoveEmptyEntries), length));
        }

        private IEnumerable<string> Wrap(IEnumerable<string> words, int lineLength)
        {
            var currentLength = 0;
            foreach (var word in words)
            {
                if (currentLength > 0  )
                {
                    yield return ReturnNewLineOrWhiteSpace(ref currentLength, word.Length, lineLength);
                    currentLength += word.Length;
                }

                //currentLength += word.Length;
                if (word.Length > lineLength)
                {
                    yield return word.Substring(0, lineLength) + "\n" + word.Substring(lineLength, word.Length - lineLength); 
                    currentLength += word.Length;
                }
                else
                {
                    yield return word;
                    currentLength += word.Length;
                }
                
            }
        }

        private string ReturnNewLineOrWhiteSpace(ref int currentLength, int wordLength, int lineLength)
        {

            if (currentLength + wordLength < lineLength)
            {
                currentLength++;
                return SWhiteSpace;
            }

            currentLength = 0;
            return SNewLine;
        }
    }
}


// && (lineLength - currentLength > word.Length) 