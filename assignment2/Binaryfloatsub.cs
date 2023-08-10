// using System;

// public class MyClass
// {
//     static int Main(string[] args)
//     {
//         // System.Console.WriteLine("Enter");
//         // double input1 = Convert.ToDouble(Console.ReadLine());
//         // double input2 = Convert.ToDouble(Console.ReadLine());
//         // System.Console.WriteLine(ConvertFloatToBinary(input1));
//         // System.Console.WriteLine(ConvertFloatToBinary(input2));
//         string binaryNo1 = "11110.000";
//         string binaryNo2 = "0100100.0";

//         System.Console.WriteLine("binary1: "+binaryNo1);
//         System.Console.WriteLine("binary2: "+binaryNo2);

//         string res = SubBinaryPointNumbers(binaryNo1, binaryNo2);
//         // System.Console.WriteLine("this is the result binary without sign " + res);

//         System.Console.WriteLine(res);
//         return 0;
//     }

// // static string ConvertFloatToBinary(string num)
// //     {
// //         string[] numParts = num.Split('.');  
// //         string numInt = numParts[0];
// //         string numFrac = numParts[1];
// //         int numIntSize = numInt.Length;
// //         int numFracSize = numFrac.Length;
// //         int integerPart = (int)num;
// //         double i = integerPart*1.0;
// //         double decimalPart = num - i;
// //         string binary = "";

// //         while (numIntSize > 0)
// //         {
// //             int temp = integerPart % 2;
// //             binary = temp + binary;
// //             integerPart /= 2;
// //         }

// //         binary += ".";
// //         if (decimalPart != 0)
// //         {

// //             while (decimalPart != 0)
// //             {
// //                 decimalPart *= 2;
// //                 if (decimalPart >= 1)
// //                 {
// //                     binary += "1";
// //                     decimalPart -= 1;
// //                 }
// //                 else
// //                 {
// //                     binary += "0";
// //                 }
// //             }
// //         }
// //         else if (decimalPart == 0)
// //         {
// //             binary += "0";
// //         }
// //         return binary;
// //     }

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
//     static string SubBinaryPointNumbers(string binaryNo1, string binaryNo2)
//     {
//         int signNum = binaryNo1[0] == '1' ? 1 : 2;
//         // System.Console.WriteLine("number having sign " + signNum);
//         binaryNo1 = binaryNo1.Substring(1);
//         // System.Console.WriteLine("num1 after removing sign bits " + binaryNo1);
//         binaryNo2 = binaryNo2.Substring(1);
//         // System.Console.WriteLine("num2 after removing sign bits " + binaryNo2);
//         string[] num1Parts = binaryNo1.Split('.');
//         string[] num2Parts = binaryNo2.Split('.');
//         string num1Int, num2Int, num1Frac, num2Frac;
//         num1Int = num1Parts[0].Length > 0 ? num1Parts[0] : "0";
//         num2Int = num2Parts[0].Length > 0 ? num2Parts[0] : "0";
//         num1Frac = num1Parts[1].Length > 0 ? num1Parts[1] : "0";
//         num2Frac = num2Parts[1].Length > 0 ? num2Parts[1] : "0";

//         // System.Console.WriteLine(num1Int + "." + num1Frac);
//         // System.Console.WriteLine(num2Int + "." + num2Frac);

//         if (num1Int.Length > num2Int.Length)
//             num2Int = num2Int.PadLeft(num1Int.Length, '0');
//         else if (num1Int.Length < num2Int.Length)
//             num1Int = num1Int.PadLeft(num2Int.Length, '0');

//         if (num1Frac.Length > num2Frac.Length)
//             num2Frac = num2Frac.PadRight(num1Frac.Length, '0');
//         else if (num1Frac.Length < num2Frac.Length)
//             num1Frac = num1Frac.PadRight(num2Frac.Length, '0');

//         binaryNo1 = num1Int + "." + num1Frac;
//         binaryNo2 = num2Int + "." + num2Frac;
//         int flag = 0;
//         for (int i = 0; i < binaryNo1.Length; i++)
//         {
//             if (binaryNo1[i] == '1' && binaryNo2[i] == '0')
//             {
//                 flag = 1;
//                 break;
//             }
//             else if (binaryNo1[i] == '0' && binaryNo2[i] == '1')
//             {
//                 flag = 2;
//                 break;
//             }
//         }

//         // System.Console.WriteLine(num1Int + "." + num1Frac);
//         // System.Console.WriteLine(num2Int + "." + num2Frac);
//         string s = AddBinaryPointNumbers(num1Int + "." + num1Frac, Complement(num2Int + "." + num2Frac));
//         // System.Console.WriteLine("this is after adding with complement " + s);
//         string signBit = "";
//         if (signNum == flag)
//             signBit = "1";
//         else signBit = "0";
//         if ((num1Int + "." + num1Frac).Length < s.Length)
//             return signBit + s.Substring(1, s.Length - 1);
//         else
//             return signBit + Complement(s.Substring(1, s.Length - 1));

//     }

//     static string Complement(string binary)
//     {
//         string res = "";
//         for (int i = 0; i < binary.Length; i++)
//         {
//             if (binary[i] == '0')
//                 res = res + '1';
//             else if (binary[i] == '1')
//                 res = res + '0';
//             else
//                 res = res + binary[i];
//         }
//         // System.Console.WriteLine("binary: " + binary);
//         // System.Console.WriteLine("complement: " + res);

//         int carry = 1;
//         int resSize = res.Length - 1;
//         string compAdd = "";
//         string[] resParts = res.Split('.');
//         string resInt, resFrac;
//         resInt = resParts[0];
//         resFrac = resParts[1];
//         while (resSize >= 0)
//         {
//             int t = res[resSize] - '0' + carry;
//             if (t == 0 || t == 1)
//             {
//                 compAdd = t + compAdd;
//                 carry = 0;
//             }
//             else if (t == 2)
//             {
//                 compAdd = '0' + compAdd;
//                 carry = 1;
//             }
//             else compAdd = '.' + compAdd;
//             resSize--;
//         }
//         // System.Console.WriteLine("1complemet" + compAdd);
//         // System.Console.WriteLine("carry = " + carry);
//         return res;
//     }
// }