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
            Assert.IsNotNull(reversed);
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

        [TestMethod]
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

        [TestMethod]
        public void Reverse_MultipleSpaces()
        {
            //arrange
            string withMultipleSpaces = "  Two spaces,   Three spaces, 1 ";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(withMultipleSpaces);

            //assert
            Assert.AreEqual("  owT secaps,   eerhT secaps, 1 ", reversed);
        }

        [TestMethod]
        public void Reverse_SpaceAtBegin()
        {
            //arrange
            string withMultipleSpaces = " Space* at begin";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(withMultipleSpaces);

            //assert
            Assert.AreEqual(" ecapS* ta nigeb", reversed);
        }

        [TestMethod]
        public void Reverse_SpaceAtEnd()
        {
            //arrange
            string spaceAtEnd = "End ";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(spaceAtEnd);

            //assert
            Assert.AreEqual("dnE ", reversed);
        }

        [TestMethod]
        public void Reverse_WithoutLetters()
        {
            //arrange
            string withoutLetters = "123 *() #";
            string reversed;
            var anagram = new Anagram();

            //act
            reversed = anagram.Reverse(withoutLetters);

            //assert
            Assert.AreEqual("123 *() #", reversed);
        }

        [TestMethod]
        public void Reverse_CheckOnNull()
        {
            //arrange
            string checkNull = null;
            var anagram = new Anagram();

            //act

            //assert
            var exception = Assert.ThrowsException<System.NullReferenceException>(() => anagram.Reverse(checkNull));
            Assert.AreEqual("Object reference not set to an instance of an object.", exception.Message);
        }
    }
}