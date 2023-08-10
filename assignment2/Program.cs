// using System;

// class Program {
//     static void Main() {
//         string numString1 = "5.0"; // Input number as a string
//         string numString2 = "0.5"; // Input number as a string
//         float num1 = float.Parse(numString1); // Parse the input string into a float
//         float num2 = float.Parse(numString2); // Parse the input string into a float
//         string binary1 = ConvertFloatToBinary(num1); // Convert the float into binary representation
//         string binary2 = ConvertFloatToBinary(num2); // Convert the float into binary representation
//         string sum = AddBinaryFloats( binary1, binary2 ); // Add the two binary floats
//         Console.WriteLine(sum);
        
//     }

//     static string ConvertFloatToBinary(float num) {
//         // Check if the number is negative
//         bool negative = num < 0;
//         if (negative) {
//             num = -num; // Get the absolute value of the number
//         }

//         // Get the integer and decimal parts of the number
//         int integerPart = (int) num;
//         float decimalPart = num - integerPart;

//         // Convert the integer part to binary
//         string binary = Convert.ToString(integerPart, 2);

//         // Convert the decimal part to binary
//         if (decimalPart != 0) {
//             binary += ".";

//             while (decimalPart != 0) {
//                 decimalPart *= 2;
//                 if (decimalPart >= 1) {
//                     binary += "1";
//                     decimalPart -= 1;
//                 }
//                 else {
//                     binary += "0";
//                 }
//             }
//         }

//         // Add sign bit for negative numbers
//         if (negative) {
//             binary = "1" + binary;
//         }
//         else {
//             binary = "0" + binary;
//         }

//         return binary;
//     }

//     static string AddBinaryFloats(string binary1, string binary2) {
//         // Get the sign bits
//         bool negative1 = binary1[0] == '1';
//         bool negative2 = binary2[0] == '1';

//         // Get the integer and decimal parts of the numbers
//         string[] parts1 = binary1.Split('.');
//         string[] parts2 = binary2.Split('.');

//         string integerPart1 = parts1[0];
//         string integerPart2 = parts2[0];

//         string decimalPart1 = parts1.Length > 1 ? parts1[1] : "";
//         string decimalPart2 = parts2.Length > 1 ? parts2[1] : "";

//         // Make the integer parts the same length
//         if (integerPart1.Length > integerPart2.Length) {
//             integerPart2 = integerPart2.PadLeft(integerPart1.Length, '0');
//         }
//         else {
//             integerPart1 = integerPart1.PadLeft(integerPart2.Length, '0');
//         }

//         // Make the decimal parts the same length
//         if (decimalPart1.Length > decimalPart2.Length) {
//             decimalPart2 = decimalPart2.PadRight(decimalPart1.Length, '0');
//         }
//         else {
//             decimalPart1 = decimalPart1.PadRight(decimalPart2.Length, '0');
//         }

//         // Add the integer parts
//         string integerPartSum = AddBinaryIntegers(integerPart1, integerPart2);

//         // Add the decimal parts
//         string decimalPartSum = AddBinaryIntegers(decimalPart1, decimalPart2);

//         // If the decimal part overflows, add 1 to the integer part
//         if (decimalPartSum.Length > decimalPart1.Length) {
//             integerPartSum = AddBinaryIntegers(integerPartSum, "1");
//             decimalPartSum = decimalPartSum.Substring(1);
//         }

//         // If the integer part overflows, add 1 to the sign bit
//         if (integerPartSum.Length > integerPart1.Length) {
//             if (negative1 && negative2) {
//                 integerPartSum = integerPartSum.Substring(1);
//                 integerPartSum = "1" + integerPartSum;
//             }
//             else if (!negative1 && !negative2) {
//                 integerPartSum = integerPartSum.Substring(1);
//                 integerPartSum = "0" + integerPartSum;

//                 // If the sign bit is 0, the result is positive
//                 negative1 = false;

//                 // If the sign bit is 1, the result is negative
//                 negative2 = true;

//                 // Add 1 to the integer part
//                 integerPartSum = AddBinaryIntegers(integerPartSum, "1");

//                 // Add 1 to the decimal part
//                 decimalPartSum = AddBinaryIntegers(decimalPartSum, "1");

//                 // If the decimal part overflows, add 1 to the integer part
//                 if (decimalPartSum.Length > decimalPart1.Length) {
//                     integerPartSum = AddBinaryIntegers(integerPartSum, "1");
//                     decimalPartSum = decimalPartSum.Substring(1);
//                 }

//                 // If the integer part overflows, add 1 to the sign bit
//                 if (integerPartSum.Length > integerPart1.Length) {
//                     integerPartSum = integerPartSum.Substring(1);
//                     integerPartSum = "1" + integerPartSum;
//                 }

//                 // If the sign bit is 0, the result is positive
//                 negative1 = false;

//                 // If the sign bit is 1, the result is negative
//                 negative2 = true;
//             }
//         }

//         // Add the sign bit
//         if (negative1 && negative2) {
//             integerPartSum = "1" + integerPartSum;
//         }
//         else {
//             integerPartSum = "0" + integerPartSum;
//         }

//         // Add the decimal part
//         if (decimalPartSum.Length > 0) {
//             integerPartSum += "." + decimalPartSum;
//         }

//         return integerPartSum;
//     }

//     static string AddBinaryIntegers(string binary1, string binary2) {
//         // Get the sign bits
//         bool negative1 = binary1[0] == '1';
//         bool negative2 = binary2[0] == '1';

//         // Get the integer parts of the numbers
//         string integerPart1 = negative1 ? binary1.Substring(1) : binary1;
//         string integerPart2 = negative2 ? binary2.Substring(1) : binary2;

//         // Make the integer parts the same length
//         if (integerPart1.Length > integerPart2.Length) {
//             integerPart2 = integerPart2.PadLeft(integerPart1.Length, '0');
//         }
//         else {
//             integerPart1 = integerPart1.PadLeft(integerPart2.Length, '0');
//         }

//         // Add the integer parts
//         string integerPartSum = "";
//         int carry = 0;
//         for (int i = integerPart1.Length - 1; i >= 0; i--) {
//             int sum = (integerPart1[i] - '0') + (integerPart2[i] - '0') + carry;
//             integerPartSum = (sum % 2) + integerPartSum;
//             carry = sum / 2;
//         }

//         // If there is a carry, add it to the result
//         if (carry > 0) {
//             integerPartSum = carry + integerPartSum;
//         }

//         // Add the sign bit
//         if (negative1 && negative2) {
//             integerPartSum = "1" + integerPartSum;
//         }
//         else {
//             integerPartSum = "0" + integerPartSum;
//         }

//         return integerPartSum;
//     }

//     // static void Main(string[] args) {
//     //     Console.WriteLine("Enter two numbers to add:");
//     //     float num1 = float.Parse(Console.ReadLine());
//     //     float num2 = float.Parse(Console.ReadLine());

//     //     string binary1 = ConvertToBinary(num1);
//     //     string binary2 = ConvertToBinary(num2);

//     //     Console.WriteLine("Binary 1: " + binary1);
//     //     Console.WriteLine("Binary 2: " + binary2);

//     //     string binarySum = AddBinaryFloats(binary1, binary2);

//     //     Console.WriteLine("Binary Sum: " + binarySum);

//     //     float sum = ConvertToFloat(binarySum);

//     //     Console.WriteLine("Sum: " + sum);
//     // }
// }
