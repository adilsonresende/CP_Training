using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week2
{
    public class PangramsBusiness
    {
        public string Pangrams(string s)
        {
            int numberOfLettersInAlphabet = 26;
            List<string> chars = Enumerable.Range('a', numberOfLettersInAlphabet).Select(x => ((char)x).ToString().ToUpperInvariant()).ToList();
            List<string> charactersFound = new List<string>();

            foreach(char c in s)
            {
                string currentChar = c.ToString().ToUpper();
                if (!chars.Contains(currentChar))
                {
                    continue;
                }

                if (!charactersFound.Contains(currentChar))
                {
                    charactersFound.Add(currentChar);
                }
            }

            string result = charactersFound.Count == numberOfLettersInAlphabet ? "pangram" : "not pangram";
            return result;
        }
    }
}
