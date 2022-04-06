using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anagram
{
    public class ManipulatingTheArray
    {
        public static bool SearchingForWord(string word)
        {
            string[] TheArray = AnagramManager.TextIntoArray();
            if (TheArray.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static object SplittingTheWord(string word)
        {
            var CharArray = word.ToCharArray();
            if (CharArray[0] == 'm')
            {
                return true;
            }
            return false;
        }

        public static string[] SameLengthWords(string word,string[] Array)
        {
            var lengthOfString = word.Length;
            var List = Array.ToList();
            foreach(var entry in Array)
            {
                if(entry.Length != lengthOfString)
                {
                    int Location = List.IndexOf(entry);
                    List.RemoveAt(Location);
                }
                
            }
            var AmmendedArray = List.ToArray();
            foreach(string Word in AmmendedArray)
            {
                Word.ToLower();
            }
            return AmmendedArray;
        }

   
    }
}
