﻿// -------------------------------------------------------------------------------------------------------------------
// <copyright company="Gemotial" file="HLStringTests.cs" project="Gmtl.HandyLib.Tests" date="2015-10-22 20:24">
// 
// </copyright>
// -------------------------------------------------------------------------------------------------------------------

using System;
using NUnit.Framework;

namespace Gmtl.HandyLib.Tests
{
    [TestFixture]
    public class HLStringTests
    {
        private string defaultValue = "default";

        [TestCase("0987654")]
        [TestCase("!~@#@*%^")]
        [TestCase("test string")]
        [TestCase("TEST STRING")]
        public void HLString_providedNonEmptyString_shouldReturnThatString(string inputString)
        {
            //Act
            string result = HLString.ValueOrDefault(inputString, defaultValue);

            //Assert
            Assert.That(result, Is.EqualTo(inputString));
        }
        
        [Test]
        public void HLString_providedEmptyString_shouldReturnDefaultValue()
        {
            //Act
            string result = HLString.ValueOrDefault(String.Empty, defaultValue);

            //Assert
            Assert.That(result, Is.EqualTo(defaultValue));
        }

        [TestCase(" ")]
        [TestCase("  ")]
        [TestCase("     ")]
        public void HLString_providedWhitespacesString_shouldReturnDefaultValue(string inputString)
        {
            //Act
            string result = HLString.ValueOrDefault(inputString, defaultValue);

            //Assert
            Assert.That(result, Is.EqualTo(defaultValue));
        }
        
        [Test]
        public void HLString_providedNUll_shouldReturnDefaultValue()
        {
            //Act
            string result = HLString.ValueOrDefault(null, defaultValue);

            //Assert
            Assert.That(result, Is.EqualTo(defaultValue));
        }

        [Test]
        public void HLString_providedNullValue_shouldReturnEmpty()
        {
            //Act
            string result = HLString.ValueOrEmpty(null);

            //Assert
            Assert.That(result, Is.EqualTo(String.Empty));
        }
        
        [Test]
        public void HLString_providedEmptyValue_shouldReturnEmpty()
        {
            //Act
            string result = HLString.ValueOrEmpty(String.Empty);

            //Assert
            Assert.That(result, Is.EqualTo(String.Empty));
        }

        [TestCase("0987654")]
        [TestCase("!~@#@*%^")]
        [TestCase("test string")]
        [TestCase("TEST STRING")]
        public void HLString_providedValue_shouldReturnIn(string input)
        {
            //Act
            string result = HLString.ValueOrEmpty(input);

            //Assert
            Assert.That(result, Is.EqualTo(input));
        }
    }
}