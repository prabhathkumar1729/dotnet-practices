// public abstract class Animal : Hello
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public abstract void Eat();
//     public abstract void Sleep();
// }

// public class Dog : Animal
// {
//     public override void Eat()
//     {
//         Console.WriteLine($"{Name} is eating dog food.");
//     }

//     public override void Sleep()
//     {
//         Console.WriteLine($"{Name} is sleeping in a dog bed.");
//     }

//     public void Bark()
//     {
//         Console.WriteLine($"{Name} is barking.");
//     }
// }

// public class Cat : Animal
// {
//     public override void Eat()
//     {
//         Console.WriteLine($"{Name} is eating cat food.");
//     }

//     public override void Sleep()
//     {
//         Console.WriteLine($"{Name} is sleeping in a cat bed.");
//     }

//     public void Meow()
//     {
//         Console.WriteLine($"{Name} is meowing.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         var dog = new Dog { Name = "Buddy", Age = 3 };
//         var cat = new Cat { Name = "Whiskers", Age = 2 };


//         dog.Eat();
//         dog.Sleep();
//         dog.Bark();

//         cat.Eat();
//         cat.Sleep();
//         cat.Meow();

//         Console.ReadLine();
//     }
// }
