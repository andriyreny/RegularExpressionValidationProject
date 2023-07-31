Instruction on how to use the app:
Download sources and open the project with Visual Studio 2022(the project uses .NET 7). Run project. 
Use the next parameters for the app testing:
•	strToValidate - parameter that contains text input to validate.
•	minLength - a parameter that contains the value for validating minimum length in text input.
•	maxLenght - a parameter that contains a value for validating maximum length in text input.
•	specialCharacters - a parameter that contains a value for validating special characters in text input.
Use case examples:
• Case 1) Set the above parameters: minLength, maxLenght, specialCharacters. Set correct text input in strToValidate: uppercase letters, lowercase letters, digits, special characters, and an acceptable range of letters (between minimum and maximum values). Without spaces, tabs, or newlines. Run project and method ValidateInput return value true.
• Case 2) Set the above parameters: minLength, maxLenght, specialCharacters. Set incorrect text input in strToValidate. For example, without uppercase letters, lowercase letters, digits, special characters, acceptable range of letters (between minimum and maximum values). Or include spaces, tabs, or newlines in text input. Run project and method ValidateInput return value false.
Regex implementation description:
The regular expression in the app checks that an input text:
•	has minimum and maximum characters in length from parameters minLength and maxLenght.
•	has at least one uppercase English letter. 
•	has at least one lowercase English letter. 
•	has at least one digit. 
•	has at least one special character form parameter specialCharacters.
•	do not contain spaces, tabs, or newlines.


