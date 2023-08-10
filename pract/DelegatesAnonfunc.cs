// using System;
// namespace DelegatesAnonymous
// {
//     public delegate void MyDelegate(int num);
//     public delegate void SingleDel();

//     public delegate void MultiDel();
//     class Program
//     {
//         public void SayHello()
//         {
//             System.Console.WriteLine("Hello.....");
//         }

//         public void SayHi()
//         {
//             System.Console.WriteLine("Hi......");
//         }

//         public void Greet()
//         {
//             System.Console.WriteLine("Good morning.....");
//         }
//         static void Main()
//         {
//             Program p = new Program();

//             System.Console.WriteLine("Single Delegate Demo");
//             SingleDel singleDelDemo = new SingleDel(p.Greet);
//             singleDelDemo();
//             System.Console.WriteLine("Multi Delegate Demo");
//             MultiDel multiDelDemo = new MultiDel(p.SayHello);
//             multiDelDemo += p.SayHi;
//             multiDelDemo += p.Greet;
//             multiDelDemo();

//             System.Console.WriteLine("Anonymous Demo");
//             MyDelegate myDelegate = delegate
//             {
//                 Console.WriteLine("This is Caller One function...");
//             };
//             myDelegate(211);

//             System.Console.WriteLine("Lambda Expression demo");
//             MyDelegate myDelegate1 = new MyDelegate((int a) => System.Console.WriteLine("This is Caller Two function..."));

//             Func<int, string> FuncDel = delegate (int a)
//             {
//                 return "Im Func Demo";
//             };

//             System.Console.WriteLine(FuncDel(10));

//             Action<string> ActionDel = delegate (string a)
//             {
//                 System.Console.WriteLine(a);
//             };

//             ActionDel("This is Action Delegate Demo");

//             System.Console.WriteLine("This is Predicate Delegate Demo");
//             Predicate<int> PredDel = delegate (int a)
//             {
//                 if (a >= 18) return true;
//                 else return false;
//             };

//             System.Console.WriteLine(PredDel(20));
//         }
//     }
// }