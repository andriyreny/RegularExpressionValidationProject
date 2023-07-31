using System.Diagnostics.CodeAnalysis;

namespace RegularExpressionValidationProject
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        private const string SpecialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        static void Main(string[] args)
        {
            var result = InputValidation.ValidateInput("1dD*fghj", 5, 20, SpecialCharacters);
            Console.WriteLine(result);
        }
    }
}

