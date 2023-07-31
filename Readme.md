Instruction on how to use the app: <br />
Download sources and open the project with Visual Studio 2022(the project uses .NET 6). Run project.  <br />
Use the next parameters for the app testing:  <br />
•	strToValidate - parameter that contains text input to validate.  <br />
•	minLength - a parameter that contains the value for validating minimum length in text input. <br />
•	maxLenght - a parameter that contains a value for validating maximum length in text input. <br />
•	specialCharacters - a parameter that contains a value for validating special characters in text input. <br />

Use case examples: <br />
• Case 1) Set the above parameters: minLength, maxLenght, specialCharacters. Set correct text input in strToValidate: uppercase letters, lowercase letters, digits, special characters, and an acceptable range of letters (between minimum and maximum values). Without spaces, tabs, or newlines. Run project and method ValidateInput return value true. <br />
• Case 2) Set the above parameters: minLength, maxLenght, specialCharacters. Set incorrect text input in strToValidate. For example, without uppercase letters, lowercase letters, digits, special characters, acceptable range of letters (between minimum and maximum values). Or include spaces, tabs, or newlines in text input. Run project and method ValidateInput return value false. <br />

Regex implementation description: <br />
The regular expression in the app checks that an input text: <br />
•	has minimum and maximum characters in length from parameters minLength and maxLenght. <br />
•	has at least one uppercase English letter.  <br />
•	has at least one lowercase English letter.  <br />
•	has at least one digit.  <br />
•	has at least one special character form parameter specialCharacters. <br />
•	do not contain spaces, tabs, or newlines. <br />


