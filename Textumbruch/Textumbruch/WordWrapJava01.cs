using System;


// "Es blaut die Nacht,die Sternlein blinken, Schneeflöcklein leis hernieder sinken."


namespace Textumbruch
{
    public class WordWrapJava01
    {
        readonly String _wrapPoint;
        readonly String _separator;
        readonly int _maxLength;

        public WordWrapJava01(String wrapPoint, String separator, int len)
        {
            this._wrapPoint = wrapPoint;
            this._separator = separator;
            if (len <= 0)
            {
                throw new Exception("limit must be > 0, was " + len);
            }
            _maxLength = len;
        }

        public WordWrapJava01(int len) : this(" ", "\n", len)
        {
        }

        public String wrap(String words)
        {
            if (words.Length <= _maxLength)
            {
                return words;
            }

            int indexToSplit = words.LastIndexOf(_wrapPoint, _maxLength);
            if (indexToSplit > 0)
            {
                return wrapAt(words, indexToSplit, _wrapPoint.Length);
            }
            return wrapAt(words, _maxLength, 0);
        }

        private String wrapAt(String words, int wrapAt, int skipChars)
        {
            return words.Substring(0, wrapAt) + _separator + wrap(words.Substring(wrapAt + skipChars));
        }

        public static String wrap(String words, int len)
        {
            return new WordWrapJava01(len).wrap(words);
        }

    }
}
