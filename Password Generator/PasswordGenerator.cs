using System;
using System.Collections.Generic;

namespace Password_Generator
{
    public class PasswordGenerator
    {
        private PasswordSize passwordSize;
        public Password Password { get; }

        public PasswordGenerator(PasswordSize passwordSize)
        {
            this.passwordSize = passwordSize;
            Password = new Password();
            Generate();
        }

        private void Generate()
        {
            Random random = new Random();

            List<char> vowels = Alphabet.Vowels;
            List<char> consonantsels = Alphabet.Consonants;

            for (int i = 0; i < (int)passwordSize; i++)
            {
                if (i % 3 == 0)
                {
                    int vowelsIndex = random.Next(0, vowels.Count);
                    Password.AppendChar(Alphabet.GetLowerOrUpperCase(vowels[vowelsIndex]));
                }
                else
                {
                    int consonantsIndex = random.Next(0, consonantsels.Count);
                    Password.AppendChar(Alphabet.GetLowerOrUpperCase(consonantsels[consonantsIndex]));
                }
            }
        }
    }
}
