namespace stackimplementation;
class StackAssignment<T>
{
    private readonly int size;
    private T[] Stack;
    private int topindex = -1;

    public StackAssignment(int arraySize)
    {
        this.size = arraySize;
        this.Stack = new T[arraySize];
    }

    public void Push(T value)
    {
        if (topindex < size - 1)
        {
            topindex++;
            Stack[topindex] = value;
        }
        else System.Console.WriteLine("Stack Overflow");
    }

    public void Pop()
    {
        if (topindex != -1)
        {
            System.Console.WriteLine("Popped: " + Stack[topindex]);
            topindex--;
        }
        else System.Console.WriteLine("Stack underflow");
    }
    public T GetTop()
    {
        return Stack[topindex];
    }

    public void PrintAll()
    {
        if (topindex != -1)
        {
            for (int i = 0; i <= topindex; i++)
                System.Console.Write(Stack[i] + " ");
            System.Console.WriteLine();
        }
        else
            System.Console.WriteLine("Empty");
    }

    public int EmptySlots()
    {
        return size - topindex - 1;
    }

    public bool IsEmpty()
    {
        if (topindex == -1)
            return true;
        else return false;
    }
}