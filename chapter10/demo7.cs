using System;
using static System.Console;
class TestHashCode
{
    static void Main()
    {
        Employee first = new Employee();
        Employee second = new Employee();
        first.Name = "John Doe";
        first.EmpNum = 15;
        second.Name = "Jane Doe";
        second.EmpNum = 25;

        Employee secondCopy = second;
        WriteLine("First ToString Override: " + first.ToString());
        WriteLine("Second ToString Override: " + second.ToString());
        WriteLine("Second Equals Override. second = secondCopy?: " +
           second.Equals(secondCopy));
        WriteLine("Second Equals Override. second = first?: " +
           second.Equals(first));

        WriteLine("First hash code " + first.GetHashCode());
        first.EmpNum = 5;
        WriteLine("Updated first hash code " + first.GetHashCode());
        //show the result of just the EmpNum or Name hash
        WriteLine("First EmpNum Hash: " + first.EmpNum.GetHashCode());
        WriteLine("First Name Hash: " + first.Name.GetHashCode());

        WriteLine("Second hash code " + second.GetHashCode());
        second.Name = "Alisha Doe";
        WriteLine("Updated second hash code " + second.GetHashCode());
        //show the result of just the EmpNum or Name hash
        WriteLine("Second EmpNum Hash: " + second.EmpNum.GetHashCode());
        WriteLine("Second Name Hash: " + second.Name.GetHashCode());

    }
}

class Employee
{
    public int EmpNum { get; set; }
    public double EmpSal { get; set; }
    public string Name { get; set; }
    public string GetGreeting()
    {
        string greeting = "Hello. I am employee #" + EmpNum;
        return greeting;
    }

    public override string ToString()
    {
        return GetType() + ": " + EmpNum + " - " + Name;
    }

    public override bool Equals(Object e)
    {
        bool isEqual;

        if (this.GetType() != e.GetType())
        //if (!(e is Employee))
        {
            isEqual = false;
        }
        else
        {
            Employee temp = (Employee)e;
            if (this.EmpNum == temp.EmpNum)
                isEqual = true;
            else
                isEqual = false;
        }
        return isEqual;
    }

    public override int GetHashCode()
    {
        //return base.GetHashCode();
        //customize the GetHashCode using the logical XOR: exclusively this OR that
        return this.EmpNum.GetHashCode() ^ this.Name.GetHashCode();
    }
}
