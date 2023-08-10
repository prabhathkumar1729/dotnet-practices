namespace stackimplementation;

class Employee
{
    int id;
    public Employee(int id)
    {
        this.id = id;
    }
    public override string ToString()
    {
        return Convert.ToString(id);
    }
}
