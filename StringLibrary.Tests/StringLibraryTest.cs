using System;
using Xunit;
using StringLibrary;

namespace StringLibrary.Tests
{
    public class StringLibraryTest
    {
        
        [Fact]
        public void TestStartsWithUpperWhenNullOrEmpty()
        {
            // Tests that we expect to return false.

            // Arrange
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                // Act
                bool result = StringLibrary.StartsWithUpper(word);

                // Asset
                Assert.False(result);
            }
        }

        [Fact]
        public void TestStartsWithLowerWhenNullOrEmpty()
        {
            // Tests that we expect to return false.

            // Arrange
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                // Act
                bool result = StringLibrary.StartsWithLower(word);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void TestStartsWithLower()
        {
            // Tests that we expect to return false.
            // Arrange
            string[] words = { "alphabet", "zebra", "abc"};
            foreach (var word in words)
            {
                // Act
                bool result = StringLibrary.StartsWithLower(word);

                // Assert
                Assert.True(result);
            }
        }

        [Fact]
        public void TestDoesNotStartWithLower()
        {
            // Tests that we expect to return true.
            // Arrange
            string[] words = { "Alphabet", "Zebra", "ABC", "1234", ".", ";", " "};
            foreach (var word in words)
            {
                // Act
                bool result = StringLibrary.StartsWithLower(word);

                // Assert
                Assert.False(result);
            }
        }

        [Fact]
        public void TestHasEmbeddedSpaces()
        {
            // Tests that we expect to return true.
            // Arrange
            string[] phrases = { "one car" };

            foreach (var phrase in phrases)
            {
                // Act
                bool result = StringLibrary.HasEmbeddedSpaces(phrase);

                // Assert
                Assert.True(result);
            }
        }
        
    }
}
