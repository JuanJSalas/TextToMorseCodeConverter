using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToMorseCodeConverter
{
    public class Converter
    {
        public MorseCode Morse { get; set; }
        private StringBuilder Sb { get; set; }

        public Converter() 
        {
            Morse = new MorseCode();
            Sb = new StringBuilder();
        }

        public string Convert(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                Sb.Append("There is no text to convert.");
            else
            {
                foreach (var letter in text)
                {
                    if (Morse.Sequences.TryGetValue(letter.ToString(), out string value))
                        Sb.Append(value);
                    else if (string.IsNullOrWhiteSpace(letter.ToString()))
                        Sb.Append(" ");
                    else
                        Sb.Append("*");
                }
            }

            return Sb.ToString();
        }
    }
}
