using System.Text.RegularExpressions;

namespace RegularExpressionValidationProject
{
    public static partial class InputValidation
    {
        private static readonly RegexOptions regexOptions = RegexOptions.Compiled;

        public static bool ValidateInput(string strToValidate, int minLength, int maxLenght, string specialCharacters) 
        {
            if (string.IsNullOrEmpty(strToValidate))
            {
                return false;
            }

            return Regex.IsMatch(strToValidate, $"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[{specialCharacters}])(?!.*[\\s]).{{{minLength},{maxLenght}}}$", regexOptions);
        }
    }
}
