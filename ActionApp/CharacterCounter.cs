using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionApp
{
    public class CharacterCounter
    {
        public int Characters(string str)
        {
            return str.Length;
        }

        public int WhitespaceCharacters(string str)
        {
            return str.Count(Char.IsWhiteSpace);
        }
    }
}
