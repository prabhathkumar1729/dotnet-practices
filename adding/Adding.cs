// using System;
// class Adding
// {
//     static string adder(int[] num1, int[] num2, int num1Size, int num2Size)
//     {
//         int[] sum = new int[num1Size];
//         int i = num1Size - 1, j = num2Size - 1, k = num1Size - 1;
//         int carry = 0, s = 0;
//         while (i >= 0)
//         {
//             s = j >= 0 ? num1[i] + num2[j] + carry : num1[i] + carry;
//             // s = num1[i] + num2[j] + carry ;
//             sum[k] = (s % 10);
//             carry = s / 10;
//             k--;
//             i--;
//             j--;
//         }
//         // while (i >= 0)
//         // {
//         //     s = num1[i] + carry;
//         //     sum[k] = (s % 10);
//         //     carry = s / 10;
//         //     i--;
//         //     k--;
//         // }
//         if (carry == 1)
//             sum[0] += 10;
//         string result = "";
//         for (int t = 0; t < num1Size; t++)
//         {
//             result = result + sum[t];
//         }
//         return result;
//     }

//     static string calSum(int[] num1, int[] num2, int num1Size, int num2Size)
//     {
//         if (num1Size >= num2Size)
//             return adder(num1, num2, num1Size, num2Size);
//         else
//             return adder(num2, num1, num2Size, num1Size);
//     }
//     public class InvalidInputException : Exception
//     {
//         public InvalidInputException(String message) : base(message)
//         {

//         }
//     }
//     public static void Main(string[] args)
//     {
//         var watch = new System.Diagnostics.Stopwatch();

//         watch.Start();
//         int[] num1 = new int[args[0].Length];
//         int[] num2 = new int[args[1].Length];
//         try
//         {
//             for (int i = 0; i < args[0].Length; i++)
//             {
//                 num1[i] = args[0][i] - '0';
//                 if (!(num1[i] >= 0 && num1[i] <= 9))
//                     throw new InvalidInputException("Found invalid char in first input");
//             }
//             for (int i = 0; i < args[1].Length; i++)
//             {
//                 num2[i] = args[1][i] - '0';
//                 if (!(num2[i] >= 0 && num2[i] <= 9))
//                     throw new InvalidInputException("Found invalid char in second input");
//             }
//             int num1Size = num1.Length;
//             int num2Size = num2.Length;
//             Console.WriteLine(calSum(num1, num2, num1Size, num2Size));
//         }
//         catch (InvalidInputException e)
//         {
//             Console.WriteLine(e);
//         }
//         watch.Stop();
//         Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
//     }
// }
