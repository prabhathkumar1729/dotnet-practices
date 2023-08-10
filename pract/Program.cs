// using System;
// public class ComplexNum
// {
//     public int real;
//     public int imaginary;
//     public ComplexNum(int real, int imaginary)
//     {
//         this.real = real;
//         this.imaginary = imaginary;
//     }
//      // Syntax of Operator Overloading
//   public static ComplexNum operator +(ComplexNum n1, ComplexNum n2)
//     {
//         return new ComplexNum(n1.real + n2.real, n1.imaginary + n2.imaginary);
//     }
//     // Override the ToString method to display an complex number in the suitable format:
//     public override string ToString()
//     {
//         return (String.Format("{0} + {1}i", real, imaginary));
//     }
//     public static void Main()
//     {
//         ComplexNum cnum1 = new ComplexNum();
//         ComplexNum cnum2 = new ComplexNum(5, 6);
//         // Add two Complex objects (num1 and num2) through the
//         ComplexNum addition = cnum1 + cnum2;
//         // Print the numbers
//         Console.WriteLine("First complex number:  {0}", cnum1);
//         Console.WriteLine("Second complex number: {0}", cnum2);
//         Console.WriteLine("RESULT :The sum of the two numbers: {0}", addition);
//         // Hault the output screen
//         Console.Read();
//     }
// }