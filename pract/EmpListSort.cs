// // using System.Collections.Generic;
// // namespace CustomCollection;

// // class EmpCollection
// // {
// //     Dictionary<string, int> emp = new Dictionary<string, int>();

// //     public static void Main()
// //     {
// //         List<int> li = new List<int>();
// //         li.Add(12);
// //         li.Add(22);
// //         li.Add(3);
// //         foreach(var i in li)
// //         {
// //             System.Console.WriteLine(i);
// //         }
// //         li.Sort();
// //     }

// // }


// using System;
// using System.Collections.Generic;

// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public Employee(int id, string name, int age)
//     {
//         this.Id = id;
//         this.Name = name;
//         this.Age = age;
//     }
//     public override string ToString()
//     {
//         return $"Employee Id: {Id}, Name: {Name}, Age: {Age}";
//     }
// }

// class EmployeeDictionary : Dictionary<int, Employee>
// {
//     public void AddEmployee(Employee employee)
//     {
//         if (this.ContainsKey(employee.Id))
//         {
//             throw new ArgumentException($"Employee with Id {employee.Id} already exists.");
//         }
//         else
//         {
//             this.Add(employee.Id, employee);
//         }
//     }

//     public void RemoveEmployee(int employeeId)
//     {
//         if (this.ContainsKey(employeeId))
//         {
//             this.Remove(employeeId);
//         }
//         else
//         {
//             throw new ArgumentException($"Employee with Id {employeeId} does not exist.");
//         }
//     }

//     public Employee GetEmployee(int employeeId)
//     {
//         if (this.ContainsKey(employeeId))
//         {
//             return this[employeeId];
//         }
//         else
//         {
//             throw new ArgumentException($"Employee with Id {employeeId} does not exist.");
//         }
//     }
// }

// class Program1
// {
//     static void Main(string[] args)
//     {
//         // EmployeeDictionary employeeDictionary = new EmployeeDictionary();

//         // Employee employee1 = new Employee() { Id = 1, Name = "John", Age = 30 };
//         // employeeDictionary.AddEmployee(employee1);

//         // Employee employee2 = new Employee() { Id = 2, Name = "Jane", Age = 25 };
//         // employeeDictionary.AddEmployee(employee2);


//         // Console.WriteLine(employeeDictionary.GetEmployee(1));
//         // Console.WriteLine(employeeDictionary.GetEmployee(2));

//         // employeeDictionary.RemoveEmployee(1);

//         // Console.WriteLine(employeeDictionary.GetEmployee(2));

//         Dictionary<Employee, int> temp = new Dictionary<Employee, int>();
//         temp.Add(new Employee(1,"a",1),1);
//         temp.Add(new Employee(1,"a",1),2);
//         System.Console.WriteLine(temp);

        // List<int> temp2 = new List<int>();
        // temp2.Add(10);
        // temp2.Add(10);
        // temp2.Add(10);
        // temp2.Add(10);
        // temp2.Count();

//     }
// }


// // class customList : ICollection<int>
// // {

// // }


// // public abstract class CollectionBase : ICollection, IEnumerable
// // {
// //     protected ArrayList InnerList { get; }

// //     public int Count => InnerList.Count;

// //     public bool IsReadOnly => InnerList.IsReadOnly;

// //     public void Add(object item) => InnerList.Add(item);

// //     public void Clear() => InnerList.Clear();

// //     public bool Contains(object item) => InnerList.Contains(item);

// //     public void CopyTo(Array array, int index) => InnerList.CopyTo(array, index);

// //     // public IEnumerator GetEnumerator() => InnerList.GetEnumerator();

// //     public bool Remove(object item)
// //     {
// //         if (InnerList.Contains(item))
// //         {
// //             InnerList.Remove(item);
// //             return true;
// //         }
// //         return false;
// //     }
// // }
