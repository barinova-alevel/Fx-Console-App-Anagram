namespace AnagramTests1
{
    using Task_1_Anagram;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseWord_ValidInput_AlphabeticalOnly()
        {
            //arrange
            string validInput = "Test string";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.ReverseWord(validInput);

            //assert
            Assert.AreEqual("gnir tstseT", reversed);
        }

        [TestMethod]
        public void ReverseWord_ValidInput_AlphabeticalWithNonAlphabetical()
        {
            //arrange
            string validInput = "Stri34ng wi%^th non *alphabetical*";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.ReverseWord(validInput);

            //assert
            Assert.AreEqual("gnir34sT ht%^iw non *lacitebahpla*", reversed);
        }

        [TestMethod]
        public void ReverseWord_InputWithCyrillic()
        {
            //arrange
            string validInput = "3Cyrillic ки##лиця їЇ₴'";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.ReverseWord(validInput);

            //assert
            Assert.AreEqual("3cilliryC яц##илик ₴Її", reversed);

        }

        [TestMethod]
        public void ReverseWord_EmptyInput()
        {
            //arrange
            string validInput = "";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.ReverseWord(validInput);

            //assert
            //Empty input, please try again

        }

        [TestMethod]
        public void ReverseWord_LongInput()
        {
            //arrange
            string validInput = "gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.ReverseWord(validInput);

            //assert
            Assert.AreEqual("Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123", reversed);

        }
    }
}