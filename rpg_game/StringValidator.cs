using System;

namespace rpg_game
{
    internal class StringValidator
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public StringValidator(int minLegth, int maxLength)
        {
            MinLength = minLegth;
            MaxLength = maxLength;
        }
        internal bool Validate(string nickname)
        {
            if (nickname.Length >= MinLength && nickname.Length <= MaxLength)
            {
                for (int charIndex = 0; charIndex < nickname.Length; charIndex++)
                {
                    if (!char.IsLetter(nickname[charIndex]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}