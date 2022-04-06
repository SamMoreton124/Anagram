using Anagram;
using System;
using NUnit.Framework;




namespace AnagramTests
{ 
    namespace AnagramTests
    {

        public class ManipulatingTheArrayTests
        {
            [Test]

            public void finds_chosen_word()
            {
                var word = "meat";
                bool Found = ManipulatingTheArray.SearchingForWord(word);
                Assert.IsTrue(Found);

            }

            [Test]
            public void returns_char_array_from_word()
            {
                var word = "meat";
                bool Found = (bool)ManipulatingTheArray.SplittingTheWord(word);
                Assert.IsTrue(Found);

            }

            [Test]

            public void changes_array_to_only_contain_same_length_words()
            {
                string word = "meat";
                string[] Array = AnagramManager.TextIntoArray();
                string[] LengthArray = ManipulatingTheArray.SameLengthWords(word, Array);
                foreach (string entry in LengthArray)
                {
                    Assert.IsTrue(entry.Length == 4);

                }
                
            }

            [Test]

            public void Searches_length_array_for_matches()
            {
                string word = "meat";
                string[] Array = AnagramManager.TextIntoArray();
                char[] splitWord = word.ToCharArray();
                string[] LengthArray = ManipulatingTheArray.SameLengthWords(word, Array);
                foreach (string entry in LengthArray)
                {
                    Assert.IsTrue(entry.Length == splitWord.Length);

                }
            }

            




            


        }
    }

}