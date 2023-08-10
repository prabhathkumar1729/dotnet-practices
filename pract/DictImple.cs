// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, int> dict = new Dictionary<string, int>();

//         dict.Add("Anu", 25);
//         dict.Add("Bharath", 30);
//         dict.Add("Chandu", 35);

//         Console.WriteLine("Count: " + dict.Count);

//         Console.WriteLine("Items:");
//         foreach (KeyValuePair<string, int> item in dict)
//         {
//             Console.WriteLine(item.Key + ": " + item.Value);
//         }

//         dict.Remove("Chandu");

//         bool exists = dict.ContainsKey("Bharath");
//         Console.WriteLine("Bharath exists: " + exists);

//         int value = dict["Anu"];
//         Console.WriteLine("Anu's age: " + value);

//         dict["Bharath"] = 35;

//         dict.Clear();

//         Console.WriteLine("Count: " + dict.Count);
//     }
// }
