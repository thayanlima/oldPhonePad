using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePadDecoder
{
    public static class OldPhonePad
    {
        private static readonly Dictionary<char, string> KeyMappings = new Dictionary<char, string>
        {
            {'1', ""},
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"},
            {'0', " "}
        };

        public static string Decode(string input)
        {
            if (string.IsNullOrEmpty(input) || input[^1] != '#')
                return "";

            var output = new StringBuilder();
            var currentSequence = new StringBuilder();

            void ProcessCurrent()
            {
                if (currentSequence.Length > 0)
                {
                    ProcessSequence(currentSequence.ToString(), output);
                    currentSequence.Clear();
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '#')
                {
                    ProcessCurrent();
                    break;
                }
                else if (c == '*')
                {
                    ProcessCurrent();
                    if (output.Length > 0)
                        output.Remove(output.Length - 1, 1);
                }
                else if (c == ' ')
                {
                    ProcessCurrent();
                }
                else if (char.IsDigit(c))
                {
                    if (currentSequence.Length > 0 && currentSequence[0] != c)
                    {
                        ProcessCurrent();
                    }
                    currentSequence.Append(c);
                }
            }

            ProcessCurrent();

            return output.ToString();
        }

        private static void ProcessSequence(string sequence, StringBuilder output)
        {
            if (string.IsNullOrEmpty(sequence)) return;

            char key = sequence[0];
            int pressCount = sequence.Length;

            if (KeyMappings.ContainsKey(key) && KeyMappings[key].Length > 0)
            {
                string letters = KeyMappings[key];
                int index = (pressCount - 1) % letters.Length;
                output.Append(letters[index]);
            }
        }
    }
}
