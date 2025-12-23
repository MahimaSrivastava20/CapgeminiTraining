using System.IO.Compression;
namespace HelloWorldApp
{
class Employee
{
    int Id;
    string Name;
    string Department;
    float Salary;
    char Gender;
    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employees Details");
        Console.WriteLine("Enter Employees Id");
        Id= Convert.ToInt32(Console.ReadLine());
        //Id= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Employees Name");
        Name=Console.ReadLine();
        Console.WriteLine("Enter Employees Department");
        Department=Console.ReadLine();
        Console.WriteLine("Enter Employees Salary"); 
        Salary=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter Employees Gender");
        Gender=Convert.ToChar(Console.ReadLine());  

    }
    public void DisplayDetail()
    {
        Console.WriteLine("Employees Details Are");
        Console.WriteLine($"Employees Id is {Id}");
        Console.WriteLine($"Employees Name is {Name}");
        Console.WriteLine($"Employees Department is {Department}");
        Console.WriteLine($"Employees Gender is {Gender}");
    }
}
}