using static System.Console;
class DemoCommissionEmployee4
{
    static void Main()
    {
        CommissionEmployee salesperson = new CommissionEmployee();
    }
}
class Employee
{
    private int idNum;
    protected double salary;
    public string Name { get; set; }

    public Employee()
    {
        WriteLine("Employee constructed");
    }
    public Employee(string name)
    {
        this.Name = name;
        WriteLine("Employee {0} constructed", name);
    }
}
class CommissionEmployee : Employee
{
    public CommissionEmployee()
    {
       WriteLine("CommissionEmployee constructed");
    }

   //  public CommissionEmployee() : base("Mark")
   //  {
   //      WriteLine("CommissionEmployee {0} constructed", Name);
   //  }

}
