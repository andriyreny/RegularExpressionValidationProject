using NUnit.Framework;
using RegularExpressionValidationProject;

namespace UnitTestProject
{
    public class Tests
    {
        private const string SpecialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        private string? strToInput = null;
        private int minLength = 5;
        private int maxLenght = 20;

        [Test]
        public void InputValidation_ValidateInput_ArgumnetIsNull()
        {
            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetContainCorrectCharactersAndHasCorrectLength()
        {
            //Arrange
            strToInput = "1WdD*fghj";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.True(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetExceedMaxLength()
        {
            //Arrange
            strToInput = "1234567890W1Wdd*fghj234567890";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetLessThanMinLength()
        {
            //Arrange
            strToInput = "1dD*";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetDoNotContainUpperCase()
        {
            //Arrange
            strToInput = "1dd*fghj";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetDoNotContainDigit()
        {
            //Arrange
            strToInput = "WDd*fghj";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetDoNotContainLowerCase()
        {
            //Arrange
            strToInput = "WDD*1DFC";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetDoNotContainSpecialCharacter()
        {
            //Arrange
            strToInput = "1WdDfghj";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetContainWhiteSpace()
        {
            //Arrange
            strToInput = "1Wdd*fghj ";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetContainNewLine()
        {
            //Arrange
            strToInput = "1Wdd*fghj" + Environment.NewLine;

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }

        [Test]
        public void InputValidation_ValidateInput_ArgumnetContainTabCharacter()
        {
            //Arrange
            strToInput = "1Wdd*fghj\t";

            //Act
            var result = InputValidation.ValidateInput(strToInput, minLength, maxLenght, SpecialCharacters);

            //Assert
            Assert.False(result);
        }
    }
}