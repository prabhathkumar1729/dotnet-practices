// using System;
// namespace ExtensionMethods
// {
//     public static class StringExtension
//     {
//         public static int GetWordCount(this string inputstring)
//         {
//             if (!string.IsNullOrEmpty(inputstring))
//             {
//                 string[] strArray = inputstring.Split(' ');
//                 return strArray.Count();
//             }
//             else
//             {
//                 return 0;
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // string myWord = "Welcome to office";
//             // int wordCount = myWord.GetWordCount();
//             // Console.WriteLine("string : " + myWord);
//             // Console.WriteLine("Count : " + wordCount);
//             // Console.Read();
//             System.Console.WriteLine("");
//         }
//     }
// }