using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anagram
{
    public class SearchingTheArray
    {
        
        public static string[] FindingAnagrams(string[] wordList , string word)
        {
            var SplitWord = word.ToCharArray();

            List<string> AddingMatchingWords = new List<string>();
      

            foreach(string PotentialMatch in wordList)
            {
                string LowerCaseMatch = PotentialMatch.ToLower();
                int count = 0;
                foreach (char Letter in SplitWord)
                {
                    if(LowerCaseMatch.Contains(Letter))
                    {
                        count++;
                    }
                    if(count >= SplitWord.Length)
                    {
                       AddingMatchingWords.Add(PotentialMatch);
                    }
                }
            }

            string[] FinalArray = AddingMatchingWords.ToArray();
            return FinalArray;

        }
    }
}
