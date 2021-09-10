using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class AnagramTest
    {
        
        [Theory]
        [InlineData("a@\uD83DB", "aB", "string 1")]
        [InlineData("ab", "a@\uD83DB", "string 2")]
        [InlineData("a\ud83e\udd70B", "aB", "string 1")]
        [InlineData("ab", "a\ud83e\udd70B", "string 2")]
        public void IsAnagram_InvalidStringShouldFail(string s1, string s2, string param)
        {
            Assert.Throws<ArgumentException>(param, () => Anagram.IsAnagram(s1, s2));
        }


        [Theory]
        [InlineData("anagram", "gamanra")]
        [InlineData("AnAGram", "gramana")]
        [InlineData("anagram", "naagram")]
        [InlineData("anagram", "anargam")]
        [InlineData("anagram", "anagrma")]
        [InlineData("an", "na")]
        [InlineData("New York Times", "monkeys write")]
        [InlineData("New, York Times", "monkeys write")]
        [InlineData("New, York, Times", "monkeys write")]
        [InlineData("New York Times", "monkeys, write")]
        [InlineData("New York Times", "monkeys, write,")]
        public void IsAnagram_ShouldWork(string s1, string s2)
        {
            Assert.True(Anagram.IsAnagram(s1, s2));
        }


        [Theory]
        [InlineData("anagram", "cdefkx")]
        [InlineData("anagram", "just")]
        [InlineData("anagram", "anagram")]
        [InlineData("anagram", "aNagram")]
        [InlineData("aNaGram", "anagram")]
        [InlineData("anagram", "nnagram")]
        [InlineData("anagram", "angrram")]
        [InlineData("anagram", "anagrmm")]
        [InlineData("a", "a")]        
        public void IsAnagram_ShouldFail(string s1, string s2)
        {
            Assert.False(Anagram.IsAnagram(s1, s2));
        }
    }
}
