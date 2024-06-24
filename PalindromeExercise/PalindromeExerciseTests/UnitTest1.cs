using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests;

public class UnitTest1
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("level", true)]
    [InlineData("hello", false)]
    [InlineData("civic", true)]
    [InlineData("Example", false)]

    public void PalindromeTest(string word, bool expected)
    {
        Palindrome test = new Palindrome();

        bool actual = test.PalindromeDetection(word);

        Assert.Equal(actual, expected);
    }
}
