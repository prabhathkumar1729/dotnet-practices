// using System;
// public class Binarycalc
// {
//     static string ConvertFloatToBinary(double num)
//     {
//         int integerPart = (int)num;
//         double i = integerPart * 1.0;
//         double decimalPart = num - i;
//         // System.Console.WriteLine(decimalPart);
//         string binary = "";

//         if (integerPart == 0)
//             binary = "00";
//         else
//         {
//             while (integerPart > 0)
//             {
//                 int temp = integerPart % 2;
//                 binary = temp + binary;
//                 integerPart /= 2;
//             }
//         }

//         binary += ".";
//         if (decimalPart != 0)
//         {

//             while (decimalPart != 0)
//             {

//                 decimalPart *= 2;
//                 if (decimalPart >= 1)
//                 {
//                     binary += "1";
//                     decimalPart -= 1;
//                 }
//                 else
//                 {
//                     binary += "0";
//                 }
//             }
//         }
//         else if (decimalPart == 0)
//         {
//             binary += "0";
//         }
//         System.Console.WriteLine(binary);
//         return binary;
//     }

//     static double binaryToDecimal(string binary, int len)
//     {
//         // int signNum = binary[0] == '1' ? 1 : 2;
//         // binary = binary.Substring(1);
//         // System.Console.WriteLine("num1 after removing sign bits " + binary);
//         int point = binary.IndexOf('.');
//         double intDecimal = 0,
//                fracDecimal = 0,
//                twos = 1;
//         for (int i = point - 1; i >= 0; i--)
//         {
//             intDecimal += (binary[i] - '0') * twos;
//             twos *= 2;
//         }
//         twos = 2;
//         for (int i = point + 1; i < len; i++)
//         {
//             fracDecimal += (binary[i] - '0') / twos;
//             twos *= 2.0;
//         }
//         return intDecimal + fracDecimal;
//     }


//     static string AddBinaryPointNumbers(string binaryNo1, string binaryNo2)
//     {
//         string[] num1Parts = binaryNo1.Split('.');
//         string[] num2Parts = binaryNo2.Split('.');
//         string num1Int, num2Int, num1Frac, num2Frac;


//         if (num1Parts[0].Length >= num2Parts[0].Length)
//         {
//             num1Int = num1Parts[0];
//             num2Int = num2Parts[0];
//         }
//         else
//         {
//             num1Int = num2Parts[0];
//             num2Int = num1Parts[0];
//         }


//         if (num1Parts[1].Length >= num2Parts[1].Length)
//         {
//             num1Frac = num1Parts[1];
//             num2Frac = num2Parts[1];
//         }
//         else
//         {
//             num1Frac = num2Parts[1];
//             num2Frac = num1Parts[1];
//         }
//         int carry = 0;
//         string add = "";
//         int i = num1Frac.Length - 1, j = num2Frac.Length - 1;
//         int maxFracSize = num1Frac.Length > num2Frac.Length ? num1Frac.Length : num1Frac.Length;
//         while (i >= 0)
//         {
//             if (i > j)
//             {
//                 add = num1Frac[i] + add;
//             }
//             else
//             {
//                 int temp = (num1Frac[i] - '0') + (num2Frac[i] - '0') + carry;
//                 if (temp <= 1)
//                 {
//                     add = temp + add;
//                     carry = 0;
//                 }
//                 else if (temp == 2)
//                 {
//                     add = "0" + add;
//                     carry = 1;
//                 }
//                 else
//                 {
//                     add = "1" + add;
//                     carry = 1;
//                 }
//             }
//             i--;
//         }
//         add = "." + add;
//         i = num1Int.Length - 1;
//         j = num2Int.Length - 1;
//         while (i >= 0)
//         {
//             if (j < 0)
//             {
//                 int temp = (num1Int[i] - '0') + carry;
//                 if (temp < 2)
//                 {
//                     add = temp + add;
//                     carry = 0;
//                 }
//                 else
//                 {
//                     add = "0" + add;
//                     carry = 1;
//                 }
//             }
//             else
//             {
//                 int temp = (num1Int[i] - '0') + (num2Int[j] - '0') + carry;
//                 if (temp <= 1)
//                 {
//                     add = temp + add;
//                     carry = 0;
//                 }
//                 else if (temp == 2)
//                 {
//                     add = "0" + add;
//                     carry = 1;
//                 }
//                 else
//                 {
//                     add = "1" + add;
//                     carry = 1;
//                 }
//             }
//             i--;
//             j--;
//         }
//         if (carry == 1)
//         {
//             add = "1" + add;
//         }
//         return add;
//     }
//     static int Main(string[] args)
//     {
//         try
//         {
//             System.Console.WriteLine("enter");
//             double input1 = Convert.ToDouble(Console.ReadLine());
//             double input2 = Convert.ToDouble(Console.ReadLine());
//             string binarySum = AddBinaryPointNumbers(ConvertFloatToBinary(input1), ConvertFloatToBinary(input2));
//             // System.Console.WriteLine(binarySum);
//             System.Console.WriteLine(binaryToDecimal(binarySum, binarySum.Length));
//         }
//         catch (Exception e)
//         {
//             System.Console.WriteLine(e);
//         }
//         return 0;
//     }

// }