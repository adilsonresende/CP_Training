using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Training.Business.Week2
{
    public class MarsExplorationBusiness
    {
        public int MarsExploration(string s)
        {
            List<string> separateWords = new List<string>();
            int result = 0;
            int currentPosition = 0;
            int wordLenght = 3;
            for (int i = 0; i < s.Length; i += wordLenght)
            {
                string currentWord = s.Substring(currentPosition, wordLenght);
                separateWords.Add(currentWord);
                currentPosition += wordLenght;
            }

            for (int wordIndex = 0; wordIndex < separateWords.Count; wordIndex++)
            {
                string word = separateWords[wordIndex];
                for (int i = 0; i < word.Length; i++)
                {
                    if ((i == 0 || i == 2) && word[i].ToString() != "S")
                    {
                        result++;
                    }
                    else if (i == 1 && word[i].ToString() != "O")
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
