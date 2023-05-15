using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToMorseCodeConverter
{
    public class MorseCode
    {
        public Dictionary<string, string> Sequences { get; set; }
        public MorseCode()
        {
            Sequences = new Dictionary<string, string>();
            PopulateSequences();
        }

        private void PopulateSequences()
        {
            Sequences.Add("A", ".-");
            Sequences.Add("B", "-...");
            Sequences.Add("C", "-.-.");
            Sequences.Add("D", "-..");
            Sequences.Add("E", ".");
            Sequences.Add("F", "..-.");
            Sequences.Add("G", "--.");
            Sequences.Add("H", "....");
            Sequences.Add("I", "..");
            Sequences.Add("J", ".---");
            Sequences.Add("K", "-.-");
            Sequences.Add("L", ".-..");
            Sequences.Add("M", "--");
            Sequences.Add("N", "-.");
            Sequences.Add("O", "---");
            Sequences.Add("P", ".--.");
            Sequences.Add("Q", "--.-");
            Sequences.Add("R", ".-.");
            Sequences.Add("S", "...");
            Sequences.Add("T", "-");
            Sequences.Add("U", "..-");
            Sequences.Add("V", "...-");
            Sequences.Add("W", ".--");
            Sequences.Add("X", "-..-");
            Sequences.Add("Y", "-.--");
            Sequences.Add("Z", "--..");
            Sequences.Add("1", ".----");
            Sequences.Add("2", "..---");
            Sequences.Add("3", "...--");
            Sequences.Add("4", "....-");
            Sequences.Add("5", ".....");
            Sequences.Add("6", "-....");
            Sequences.Add("7", "--...");
            Sequences.Add("8", "---..");
            Sequences.Add("9", "----.");
            Sequences.Add("0", "-----");
        }
    }
}
