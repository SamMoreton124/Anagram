using Anagram;
using NUnit.Framework;




namespace AnagramTests
{ 
    namespace AnagramTests
    {

        public class SearchingTheArrayTest
        {
            

            [Test]

            public void Removing_Non_Matching_words()
            {
                string word = "bored";
                string[] ArrayOfWords = AnagramManager.TextIntoArray();
                char[] splitWord = word.ToCharArray();
                string[] LengthArray = ManipulatingTheArray.SameLengthWords(word, ArrayOfWords);
                string[] MatchingArray = SearchingTheArray.FindingAnagrams(LengthArray, word);

                Assert.AreEqual("borde", MatchingArray[0]);
            }





        }
    }

}