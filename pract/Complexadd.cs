// using System;
// namespace OperatorOverloading
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             ComplexNo no1 = new ComplexNo();
//             ComplexNo no2 = new ComplexNo(4, 5);
//             ComplexNo no3 = no1 + no2;
//             no3.Display();
//         }
//     }
//     public class ComplexNo
//     {
//         public int realNo;
//         public int imgNo;
//         public ComplexNo(int real, int img)
//         {
//             this.realNo = real;
//             this.imgNo = img;
//         }
//         public static ComplexNo operator +(ComplexNo no1, ComplexNo no2)
//         {

//             // int realNo = no1.realNo + no2.realNo;
//             // int imgNo = no1.imgNo + no2.imgNo;
//             // return new ComplexNo(realNo, imgNo);

//             ComplexNo cn = new ComplexNo(0,0);
//             cn.realNo = no1.realNo + no2.realNo;
//             cn.imgNo = no1.imgNo + no2.imgNo;
//             return cn;
//         }
//         public void Display()
//         {
//             Console.WriteLine($"{realNo} + ({imgNo})i");
//         }
//     }

// }