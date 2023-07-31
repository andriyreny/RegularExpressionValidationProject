using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace RegularExpressionValidationProject
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        private const string SpecialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        static void Main(string[] args)
        {
            Regex.CacheSize += 100;

            var result = InputValidation.ValidateInput("1dD*fghj", 5, 20, SpecialCharacters);
            Console.WriteLine(result);
        }
    }
}

