using Anagram;
using NUnit.Framework;




namespace AnagramTests
{ 
    namespace AnagramTests
    {

        public class AnagramUnitTest
        {
            [Test]
            public void First_line_of_text_file_is_returned()
            {
               
                var returned = AnagramManager.ReturnLine();
                Assert.AreEqual(returned, "A");
            }

            [Test]
            public void text_file_returns_array()
            {
                string[] returned = AnagramManager.TextIntoArray();
                var type = returned.GetType();
                Assert.IsTrue(type.Equals(typeof(string[])));
            }

           
           


            
           


        }
    }

}