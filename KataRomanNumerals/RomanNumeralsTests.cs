﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRomanNumerals
{
    using Xunit;

    public class RomanNumeralsTests
    {
        private RomanNumerals numerals;

        public RomanNumeralsTests()
        {
            this.numerals = new RomanNumerals();
        }

        [Fact]
        public void Should_return_I_when_translate_1_to_roman_number()
        {
            // Arrange

            // Act
            var romanNumber = numerals.Translate(1);

            // Assert
            Assert.Equal("I", romanNumber);
        }

        [Fact]
        public void Should_return_II_when_translate_2_to_roman_number()
        {
            // Arrange

            // Act
            var romanNumber = numerals.Translate(2);

            // Assert
            Assert.Equal("II", romanNumber);
        }

        [Fact]
        public void Should_return_IV_when_translate_4_to_roman_number()
        {
            // Arrange

            // Act
            var romanNumber = numerals.Translate(4);

            // Assert
            Assert.Equal("IV", romanNumber);
        }


        [Fact]
        public void Should_return_VI_when_translate_6_to_roman_number()
        {
            // Arrange

            // Act
            var romanNumber = numerals.Translate(6);

            // Assert
            Assert.Equal("VI", romanNumber);
        }
    }

    public class RomanNumerals
    {
        public Dictionary<int, string> _mapRoman = new Dictionary<int, string>() { { 1, "I" }, { 2, "II" }, { 4, "IV" }, { 5, "V" } };

        public string Translate(int number)
        {
            if (_mapRoman.ContainsKey(number))
            {
                return _mapRoman[number];
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
