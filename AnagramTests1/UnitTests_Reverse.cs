namespace AnagramTests1
{
    using Task_1_Anagram;

    [TestClass]
    public class UnitTests_Reverse
    {
        [TestMethod]
        public void Reverse_ValidInput_AlphabeticalOnly()
        {
            //arrange
            string validInput = "Test string";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(validInput);

            //assert
            Assert.AreEqual("tseT gnirts", reversed);
        }

        [TestMethod]
        public void Reverse_ValidInput_AlphabeticalWithNonAlphabetical()
        {
            //arrange
            string validInput = "Stri34ng wi%^th non #alphabetical*";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(validInput);

            //assert
            Assert.AreEqual("gnir34tS ht%^iw non #lacitebahpla*", reversed);
        }

        [TestMethod]
        public void Reverse_InputWithCyrillic()
        {
            //arrange
            string validInput = "3Cyrillic ки##лиця їЇ₴";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(validInput);

            //assert
            Assert.AreEqual("3cilliryC яц##илик Її₴", reversed);

        }

        [TestMethod]
        public void Reverse_EmptyInput()
        {
            //arrange
            string input = "";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(input);

            //assert
            //Empty input, please try again

        }

        [TestMethod]
        public void Reverse_LongInput()
        {
            //arrange
            string validInput = "gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123 gnoL tupni 123";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(validInput);

            //assert
            Assert.AreEqual("Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123 Long input 123", reversed);
        }

        public void Reverse_ShortInput()
        {
            //arrange
            string validInput = "sh0rt";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(validInput);

            //assert
            Assert.AreEqual("tr0hs", reversed);

        }
    }
}