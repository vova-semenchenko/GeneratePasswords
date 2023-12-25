using System;
using System.Collections.Generic;

namespace Password_Generator
{
    public static class Alphabet
    {
        public static List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'e' };


        public static List<char> Consonants = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'y' };


        private static Random r = new Random();

        public static char GetLowerOrUpperCase(char _char)
        {            
            CharCase result = (CharCase) r.Next(0, 2);
            return result == CharCase.LOWWER ? _char : char.ToUpper(_char);
        }

    }
}
