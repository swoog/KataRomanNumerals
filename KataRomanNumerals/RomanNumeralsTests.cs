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
        [Fact]
        public void Should_return_I_when_translate_1_to_roman_number()
        {
            // Arrange
            var romanNumerals = new RomanNumerals();
            
            // Act
            var romanNumber = romanNumerals.Translate(1);

            // Assert
            Assert.Equal("I", romanNumber);
        }

        [Fact]
        public void Should_return_II_when_translate_2_to_roman_number()
        {
            // Arrange
            var romanNumerals = new RomanNumerals();

            // Act
            var romanNumber = romanNumerals.Translate(2);

            // Assert
            Assert.Equal("II", romanNumber);
        }
    }

    public class RomanNumerals
    {
        public string Translate(int romanNumber)
        {
            return "I";
        }
    }
}
