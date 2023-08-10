// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         List<int> numbers = new List<int>();
//         for (int i = 0; i <= 20; i++)
//         {
//             System.Console.WriteLine("size at time= " + i + " is " + numbers.Capacity);
//             numbers.Add(i);
//         }

//         Console.WriteLine("Count: " + numbers.Count);

//         Console.WriteLine("Items:");
//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);
//         }

//         numbers.Remove(3);

//         numbers.Insert(1, 10);

//         bool exists = numbers.Contains(5);
//         Console.WriteLine("5 exists: " + exists);

//         numbers.Sort();

//         numbers.Reverse();

//         int[] array = new int[numbers.Count];
//         numbers.CopyTo(array);

//         numbers.Clear();

//         Console.WriteLine("Count: " + numbers.Count);
//     }
// }
