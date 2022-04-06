using System;
using System.Collections.Generic;
using System.Linq;


namespace Anagram
{
    public class AnagramManager
    {
     
        public static string ReturnLine()
        {
            var wordsInArray = TextIntoArray();
            return wordsInArray[0];
        }

        public static string[] TextIntoArray()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\smoreton\source\repos\Anagram\ListOfWords.txt");
            return lines; 
            
        }



    }
}
