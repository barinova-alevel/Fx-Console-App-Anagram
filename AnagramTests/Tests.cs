using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnagramTests
{
    public interface IUserInput
    {
        string GetInput();
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Reverse_ValidUserInput()
        {
            //arrange
            var anagram = new Anagram();

            //act
            anagram.Reverse();

            //assert
            Assert.AreEqual();

        }

        [TestMethod]
        public void Reverse_InvalidUserInput() 
        {
        }

        [TestMethod]
        public void Reverse_EmptyUserInput()
        {
        }
    }
}
