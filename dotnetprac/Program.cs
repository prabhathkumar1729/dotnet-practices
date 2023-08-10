// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }

// using System;

// public class MyClass
// {
//     // Static field
//     private static int staticField = 0;

//     // Instance field
//     private int instanceField = 0;

//     // Static property
//     public static int StaticProperty
//     {
//         get { return staticField; }
//         set { staticField = value; }
//     }

//     // Instance property
//     public int InstanceProperty
//     {
//         get { return instanceField; }
//         set { instanceField = value; }
//     }

//     // Static method
//     public static void StaticMethod()
//     {
//         Console.WriteLine("This is a static method.");
//     }

//     // Instance method
//     public void InstanceMethod()
//     {
//         Console.WriteLine("This is an instance method.");
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         // Access static field and property
//         MyClass.StaticProperty = 10;
//         Console.WriteLine("Static field value: {0}", MyClass.StaticProperty);

//         // Create instance and access instance field and property
//         MyClass myObj = new MyClass();
//         myObj.InstanceProperty = 20;
//         Console.WriteLine("Instance field value: {0}", myObj.InstanceProperty);

//         // Call static and instance methods
//         MyClass.StaticMethod();
//         myObj.InstanceMethod();
//     }
// }


// class Employee
// {
//     private string name;
//     private string alias;
//     private int salary = 25000;

//     // Constructor:
//     public Employee(string name, string alias)
//     {
//         // Use this to qualify the fields, name and alias:
//         this.name = name;
//         this.alias = alias;
//     }

//     // Printing method:
//     public void printEmployee()
//     {
//         Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
//         // Passing the object to the CalcTax method by using this:
//         Console.WriteLine("Annual Income {0}", Annual.CalcAnnIncome(this));
//     }

//     public int Salary
//     {
//         get { return salary; }
//     }
// }

// class Annual
// {
//     public static int CalcAnnIncome(Employee E)
//     {
//         return 12 * E.Salary;
//     }
// }

// class MainClass
// {
//     static void Main()
//     {
//         // Create objects:
//         Employee E1 = new Employee("Prabhath", "prabha");

//         // Display results:
//         E1.printEmployee();
//     }
// }


// public class HowToObjectInitializers
// {
//     public static void Main()
//     {
//         // Declare a StudentName by using the constructor that has two parameters.
//         StudentName student1 = new StudentName("Craig", "Playstead");

//         // Make the same declaration by using an object initializer and sending
//         // arguments for the first and last names. The parameterless constructor is
//         // invoked in processing this declaration, not the constructor that has
//         // two parameters.
//         StudentName student2 = new StudentName
//         {
//             FirstName = "Craig",
//             LastName = "Playstead"
//         };

//         // Declare a StudentName by using an object initializer and sending
//         // an argument for only the ID property. No corresponding constructor is
//         // necessary. Only the parameterless constructor is used to process object
//         // initializers.
//         StudentName student3 = new StudentName
//         {
//             ID = 183
//         };

//         // Declare a StudentName by using an object initializer and sending
//         // arguments for all three properties. No corresponding constructor is
//         // defined in the class.
//         StudentName student4 = new StudentName
//         {
//             FirstName = "Craig",
//             LastName = "Playstead",
//             ID = 116
//         };

//         StudentName student5 = new StudentName();

//         Console.WriteLine(student1.ToString());
//         Console.WriteLine(student2.ToString());
//         Console.WriteLine(student3.ToString());
//         Console.WriteLine(student4.ToString());
//         Console.WriteLine(student5.ToString());
//     }
//     // Output:
//     // Craig  0
//     // Craig  0
//     //   183
//     // Craig  116

//     public class StudentName
//     {
//         // This constructor has no parameters. The parameterless constructor
//         // is invoked in the processing of object initializers.
//         // You can test this by changing the access modifier from public to
//         // private. The declarations in Main that use object initializers will
//         // fail.
//         public StudentName() { }

//         // The following constructor has parameters for two of the three
//         // properties.
//         public StudentName(string first, string last)
//         {
//             FirstName = first;
//             LastName = last;
//         }

//         // Properties.
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public int ID { get; set; }

//         public override string ToString() => FirstName + LastName + "  " + ID;
//     }
// }
// C# program to sum two numbers
// represented two arrays.
// using System;

// class Adding
// {

//     // Return sum of two number represented by
//     // the arrays. Size of a[] is greater than
//     // b[]. It is made sure be the wrapper
//     // function
//     static int calSumUtil(int[] a, int[] b,
//                                 int n, int m)
//     {
//         // array to store sum.
//         int[] sum = new int[n];

//         int i = n - 1, j = m - 1, k = n - 1;

//         int carry = 0, s = 0;

//         // Until we reach beginning of array.
//         // we are comparing only for second
//         // array because we have already compare
//         // the size of array in wrapper function.
//         while (j >= 0)
//         {
//             // find sum of corresponding element
//             // of both array.
//             s = a[i] + b[j] + carry;

//             sum[k] = (s % 10);

//             // Finding carry for next sum.
//             carry = s / 10;

//             k--;
//             i--;
//             j--;
//         }

//         // If second array size is less
//         // the first array size.
//         while (i >= 0)
//         {
//             // Add carry to first array elements.
//             s = a[i] + carry;
//             sum[k] = (s % 10);
//             carry = s / 10;

//             i--;
//             k--;
//         }

//         int ans = 0;

//         // If there is carry on adding 0 index
//         // elements append 1 to total sum.
//         if (carry == 1)
//             ans = 10;

//         // Converting array into number.
//         for (i = 0; i <= n - 1; i++)
//         {
//             ans += sum[i];
//             ans *= 10;
//         }

//         return ans / 10;
//     }

//     // Wrapper Function
//     static int calSum(int[] a, int[] b, int n,
//                                         int m)
//     {
//         // Making first array which have
//         // greater number of element
//         if (n >= m)
//             return calSumUtil(a, b, n, m);

//         else
//             return calSumUtil(b, a, m, n);
//     }

//     // Driver program
//     public static void Main()
//     {
//         int[] a = { 0, 0, 0, 9, 9, 9 };
//         int[] b = { 9, 9, 9 };

//         int n = a.Length;

//         int m = b.Length;
//         Console.WriteLine(calSum(a, b, n, m));
//     }
// }



// public class Animal
// {
//     public string name;

//     public Animal(){}
//     public Animal(string inputname)
//     {
//         name = inputname;
//     } 

//     public virtual void Speak()
//     {
//         Console.WriteLine("The animal makes a sound "+ name);
//     }
//     protected virtual void dummy(){
//         System.Console.WriteLine("venu");

//     }
// }

// public class Cat : Animal
// {
//     public Cat(){}
//     public Cat(string name):base(){

//     }
//     public override void Speak()
//     {
//         Console.WriteLine("The cat meows " + name);
//     }
//      public void Eats()
//     {
//         Console.WriteLine("Eats grass");
//     }
// }
// public class CatSon:Cat{
//     protected override void dummy(){
//         System.Console.WriteLine("Naveen");

//     }

// }

// public class Dog : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("The dog barks");
//     }
// }

// public class Program
// {
//     static void Main(string[] args)
//     {
//         Animal animal1 = new Cat();
//         Animal animal2 = new Dog();
//         Dog animal3 = new Dog();
//         Animal animal4 = new Animal();
//         Cat animal5 = new Cat();
//         //    animal1.Eats();
//         //    animal5.Eats();

//         animal1.Speak(); // Outputs "The cat meows"
//         animal2.Speak(); // Outputs "The dog barks"
//         animal3.Speak();
//         animal4.Speak(); 
//         animal5.Speak();
//     }
// }

// using System;

// namespace MethodOverload {

//   class Program {  

//     // method with int and string parameters 
//     void display(int a, string b) {
//         System.Console.WriteLine("im in first display");
//       Console.WriteLine("int: " + a);
//       Console.WriteLine("string: " + b);
//     } 

//     // method with string andint parameter
//     void display(string b, int a) {
//         System.Console.WriteLine("im in second");
//       Console.WriteLine("string: " + b);
//       Console.WriteLine("int: " + a);
//     } 
//     static void Main(string[] args) {

//       Program p1 = new Program();
//       p1.display(100, "Programming");
//       p1.display("Programiz", 400);
//       Console.ReadLine();
//     }
//   }
// }

// namespace ConsoleApplication
// { 
//     class index
//     {
//         protected int count;
//         public index()
//         {
//             count = 0;
//             System.Console.WriteLine("starting");
//         }
//     }
//     class index1: index
//     {
//         public void increment()
//         {
//             System.Console.WriteLine("in index1");
//             count = count +1;
//             System.Console.WriteLine("count "+ count);
//         }
//     }
//     class MyProgram
//     {
//         static void Main(string[] args)
//         {
//             index1 i = new index1(); 
//             i.increment(); 
//         }
//     }
// }


// namespace Application
// { 
//     class Baseclass
//     { 
//         public void fun()
//         { 
//             Console.Write("Base class" + " ");
//         } 
//     } 
//     class Derived1: Baseclass
//     { 
//         new void fun()
//         {
//             Console.Write("Derived1 class" + " "); 
//         } 
//     } 
//     class Derived2: Derived1
//     { 
//         new void fun()
//         { 
//             Console.Write("Derived2 class" + " ");
//         }
//     }
//     class Program
//     { 
//         public static void Main(string[ ] args)
//         { 
//             Derived2 d = new Derived2(); 
//             d.fun(); 
//         } 
//     } 
// }



// class Baseclass
// {
//     int i;
//     public Baseclass(int ii)
//     {
//         i = ii;
//         Console.Write("Base ");
//     }
// }
// class Derived : Baseclass
// {
//     public Derived(int ii) : base(ii)
//     {
//         Console.Write("Derived ");
//     }
// }
// class MyProgram
// {
//     static void Main(string[] args)
//     {
//         Derived d = new Derived(10);
//     }
// }

