class Program
{
    public static void Main()
    {
        // Console.WriteLine("Creating Object...");

        // for(int i=0; i<5; i++)
        // {
        //     MyClass myClass = new MyClass();
        // }
        // Console.WriteLine("Forcing Garbage Collection...");

        // GC.Collect();
        // GC.WaitForPendingFinalizers();

        // Console.WriteLine("Garbage Collection Completed!");

        // Console.WriteLine("Tuple Example:");
        // TupleExample.Tuples();

        // Tuple Usage
        // var obj = TupleExample.Calculate(10, 15);
        // Console.WriteLine(obj.GetType());
        // Console.WriteLine("Sum: " + obj.sum);
        // Console.WriteLine("Avg: " + obj.avg);
        // Console.WriteLine("Difference: " + obj.diff);

        // Console.WriteLine("---------------");
        // var response = TupleExample.ValidateUser("Admin");
        // Console.WriteLine(response.message);
        // Console.WriteLine(response.isValid);
        
        // Console.WriteLine("----------------");
        // var person = (Id: 1, Name: "Aryan");
        // Console.WriteLine(person.Id);
        // Console.WriteLine(person.GetType());
        // Console.WriteLine(person.Id.GetType());

        // var (id, name) = person;
        // Console.WriteLine(id);
        // Console.WriteLine(id.GetType());

        // Console.WriteLine("----------------");
        // (int ide, string Personname) = person;
        // Console.WriteLine("ID: "+ide);
        // Console.WriteLine("Person Name: "+Personname);

        // Console.WriteLine("----------------");
        // var (_, userName) = person;
        // Console.WriteLine("Person Name: "+ userName);
        // var (idx, _) = person;
        // Console.WriteLine("ID: "+ idx);

        Console.WriteLine("------- Deconstruction ---------");
        // var s = new Student { Id = 1, Name = "Amit" };
        // s.GetType();
        // var (sid, sname) = s;

        // Console.WriteLine(sid);
        // Console.WriteLine(sname);
        // Console.WriteLine("s Type: "+ s.GetType());

        Console.WriteLine("-------   LINQ  ---------");
        int[] number = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        foreach (var num in number)
        {
            Console.Write(" " + num);
        }
        Console.WriteLine();

        var evenNumber = number.Where(n => n % 2 == 0);
        Console.WriteLine("Type of EvenNumber: " + evenNumber.GetType());

        var updatedNumber = number.Where(n => n > 3).Select(n => n * 2);
        foreach(var num in updatedNumber)
        {
            Console.Write(" " + num);
        }
        Console.WriteLine();
        Console.WriteLine("Type of updatedNumber: " + updatedNumber.GetType());

        List<int> list = new List<int>{1, 5, 8, 3, 2, 0, 6};

        var ascending = list.OrderBy(n => n);
        Console.Write("Ascending Order: ");
        foreach(var num in ascending)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        var descending = list.OrderByDescending(n => n);
        Console.Write("Descending Order: ");

        foreach (var num in descending)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.WriteLine("---------- Order By ----------");
        List<Employee> employees = new List<Employee>
        {
            new Employee{Name="Aryan", Salary=90000},
            new Employee{Name="Mohit", Salary=50000},
            new Employee{Name="Kavish", Salary=70000},

        };
        var sortedBySalary = employees.OrderBy(e => e.Salary);
        foreach(var obj in sortedBySalary)
        {
            Console.WriteLine("Name: " + obj.Name + " ");
            Console.WriteLine("Salary: " + obj.Salary + " ");
        }

        Console.WriteLine("---------- Order By Descending----------");

        var sortedBySalaryDesc = employees.OrderByDescending(e => e.Salary);
        foreach(var obj in sortedBySalaryDesc)
        {
            Console.WriteLine("Name: " + obj.Name + " ");
            Console.WriteLine("Salary: " + obj.Salary + " ");
        }

        Console.WriteLine("---------- IDisposable Interface----------");    // IDisposable used for unmanaged Resource like fileHandling.
        Console.WriteLine("---------- Using Statement----------");

        using (ResourceHandler resourceHandler = new ResourceHandler())
        {
            Console.WriteLine("Using Resource...");
        }
        Console.WriteLine("End of program.");



        Console.WriteLine("-------------- Large Object Heap ---------------");
        GarbageCollection.Collection();




    }
}
class MyClass
{
    ~MyClass()
    {
        Console.WriteLine("Finalizer Called, Oobject Collected..");
    }
}
class Employee
{
    public string Name {get; set;}
    public int Salary {get; set;}
}