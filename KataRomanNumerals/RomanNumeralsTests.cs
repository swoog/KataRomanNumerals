using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRomanNumerals
{
    using Xunit;

    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        [InlineData("VI", 6)]
        [InlineData("X", 10)]
        [InlineData("IX", 9)]
        [InlineData("XIX", 19)]
        [InlineData("L", 50)]
        public void Should_return_roman_number_when_translate_number(string expectedRomanNumber, int number)
        {
            // Arrange
            var romanNumerals = new RomanNumerals();

            // Act
            var romanNumber = romanNumerals.Translate(number);

            // Assert
            Assert.Equal(expectedRomanNumber, romanNumber);
        }
    }

    public class RomanNumerals
    {
        private readonly Dictionary<int, string> _mapRoman = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 2, "II" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" }
        };

        public string Translate(int number)
        {
            string romanNumber;
            if (_mapRoman.TryGetValue(number, out romanNumber))
            {
                return romanNumber;
            }

            var max = FindMaxNumberMinusThan(number);

            return Translate(max) + Translate(number - max);
        }

        private int FindMaxNumberMinusThan(int romanNumber)
        {
            return _mapRoman.Keys.Where(n => n < romanNumber).Max();
        }
    }
}
