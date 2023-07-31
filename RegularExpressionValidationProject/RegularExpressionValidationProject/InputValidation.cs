using System.Text.RegularExpressions;

namespace RegularExpressionValidationProject
{
    public class InputValidation
    {
        public static bool ValidateInput(string strToValidate, int minLength, int maxLenght, string specialCharacters) 
        {
            if (string.IsNullOrEmpty(strToValidate))
            {
                return false;
            }

            var validateGuidRegex = new Regex($"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[{specialCharacters}])(?!.*[\\s]).{{{minLength},{maxLenght}}}$");

            return validateGuidRegex.IsMatch(strToValidate);
        }
    }
}
