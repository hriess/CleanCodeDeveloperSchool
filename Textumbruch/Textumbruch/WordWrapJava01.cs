using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textumbruch
{
    public class WordWrapJava01
    {
        private String wrapPoint;
        private String separator;
        private int maxLength;

        public WordWrapJava01(String wrapPoint, String separator, int len)
        {
            this.wrapPoint = wrapPoint;
            this.separator = separator;
            if (len <= 0)
            {
                throw new Exception("limit must be > 0, was " + len);
            }
            maxLength = len;
        }

        public WordWrapJava01(int len) : this(" ", "\n", len)
        {
            ;
        }

        public String wrap(String words)
        {
            if (words.Length <= maxLength)
            {
                return words;
            }

            int indexToSplit = words.LastIndexOf(wrapPoint, maxLength);
            if (indexToSplit > 0)
            {
                return wrapAt(words, indexToSplit, wrapPoint.Length);
            }
            return wrapAt(words, maxLength, 0);
        }

        private String wrapAt(String words, int wrapAt, int skipChars)
        {
            return words.Substring(0, wrapAt) + separator + wrap(words.Substring(wrapAt + skipChars));
        }

        public static String wrap(String words, int len)
        {
            return new WordWrapJava01(len).wrap(words);
        }

    }
}
