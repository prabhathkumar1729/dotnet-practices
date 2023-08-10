using System.Collections;
using System.Text;
namespace customCollectionImplementation;
class CustomList<T> : ICollection<T>
{
    private T[] arr;

    public CustomList()
    {
        arr = new T[0];
    }

    public T this[int index]
    {
        get
        {
            return arr[index];
        }
        set { arr[index] = value; }
    }

    public void Add(T item)
    {
        T[] tempArray = new T[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            tempArray[i] = arr[i];
        }
        tempArray[arr.Length] = item;
        arr = tempArray;
    }

    public void Clear()
    {
        arr = new T[0];
    }

    public bool Contains(T item)
    {
        foreach (T indexValue in arr)
        {
            if (indexValue.Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        arr.CopyTo(array, arrayIndex);
    }

    public int Count
    {
        get { return arr.Length; }
    }

    public bool IsReadOnly
    {
        get { return false; }
    }

    public bool Remove(T item)
    {
        if (Contains(item))
        {
            T[] tempArray = new T[arr.Length - 1];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                {
                    index++;
                    break;
                }
                else
                {
                    tempArray[i] = arr[index];
                    index++;
                }
            }

            for (int i = index - 1; index <= arr.Length - 1; i++)
            {
                tempArray[i] = arr[index];
                index++;
            }
            arr = tempArray;
            return true;
        }
        return false;
    }


    public void RemoveAt(int index = -1)
    {
        if (index > arr.Length - 1 || index < 0)
            throw new IndexOutOfRangeException();
        T[] tempArr = new T[arr.Length - 1];
        int tempIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != index)
            {
                tempArr[tempIndex] = arr[i];
                tempIndex++;
            }
        }
        arr = tempArr;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)arr).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return arr.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(arr);
    }

    public void Sort(Comparison<T> compare)
    {
        Array.Sort(arr, compare);
    }
}

class Employee : IComparable<Employee>
{
    public int id;
    public Employee(int id)
    {
        this.id = id;
    }
    public int CompareTo(Employee other)
    {
        return this.id.CompareTo(other.id);
    }

}

class Student
{
    public int rollNo;
    public Student(int rollNo)
    {
        this.rollNo = rollNo;
    }
}
class Program
{
    public static void Main(string[] args)
    {

        CustomList<Employee> empList = new CustomList<Employee>();
        empList.Add(new Employee(100));
        empList.Add(new Employee(20));
        empList.Add(new Employee(10));
        empList.Add(new Employee(100));
        empList.Add(new Employee(1000));

        empList.Sort();
        foreach (Employee i in empList)
        {
            System.Console.WriteLine(i.id);
        }

        CustomList<Student> studList = new CustomList<Student>();
        studList.Add(new Student(100));
        studList.Add(new Student(20));
        studList.Add(new Student(10));
        studList.Add(new Student(100));
        studList.Add(new Student(1000));
        Comparison<Student> CompareRollNo = (stud1, stud2) => stud1.rollNo.CompareTo(stud2.rollNo);
        studList.Sort(CompareRollNo);
        foreach (Student i in studList)
        {
            System.Console.WriteLine(i.rollNo);
        }

        StringBuilder sb = new StringBuilder();
        
    }
}
