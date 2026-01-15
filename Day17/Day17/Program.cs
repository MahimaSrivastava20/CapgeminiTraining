// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
using System.Reflection;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Day-16, Assembly and Reflection!");
        Assembly assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine(assembly);

        // Console.WriteLine(Assembly.Load("Assembly-and-Reflection"));
        // Console.WriteLine(Assembly.LoadFrom("bin/Debug/net10.0/Assembly-and-Reflection.dll"));

        Type type = typeof(Employee);

        Employee employeeObject = new Employee{Id = 101, Name = "Aryan", Age = 22};
        employeeObject.SetSalary(9000090);
        Employee employeeObject2 = new Employee();
        Console.WriteLine(employeeObject2.GetType());
        Console.WriteLine(employeeObject.GetType());

        Type type2 = employeeObject.GetType();
        // Type type3 = Type.GetType("Assembly-and-Reflection.Models.Employee");

        // Console.WriteLine(type);
        Console.WriteLine(type2);
        // Console.WriteLine(type3);

        // -----------  Method Info Class ----------------
        Console.WriteLine("-----------  Method Info Class ----------------");

        MethodInfo method = type.GetMethod("Work");
        Console.WriteLine(method);
        method.Invoke(employeeObject, new object[]{12, 3});//--



        // -----------  ParameterInfo Class ----------------
        Console.WriteLine("-----------  ParameterInfo Class ----------------");

        ParameterInfo[] parameters = method.GetParameters();
        foreach(var e in parameters)
        {
            Console.WriteLine("Parameter Name: " + e);
        }



        // -----------  PropertyInfo Class ----------------
        Console.WriteLine("-----------  PropertyInfo Class ----------------");

        PropertyInfo prop = type.GetProperty("Name");
        Console.WriteLine(prop);
        prop.SetValue(employeeObject2, "John");
        Console.WriteLine(employeeObject2.Name);




        // -----------  FieldInfo Class ----------------
        Console.WriteLine("-----------  FieldInfo Class ----------------");

        FieldInfo field = type.GetField("_salary", BindingFlags.NonPublic | BindingFlags.Instance);
        // FieldInfo field = type.GetField("_salary");   // It will not give any output because we don't use BindingFlags.NonPublic, it means look for Private field also.
        Console.WriteLine(field);
        Console.WriteLine(field.GetValue(employeeObject));
        field.SetValue(employeeObject2, 50000);
        Console.WriteLine(field.GetValue(employeeObject2));



        // -----------  ConstructorInfo Class ----------------
        Console.WriteLine("-----------  ConstructorInfo Class ----------------");

        ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);
        object obj = ctor.Invoke(null);
        Console.WriteLine(obj);
        Console.WriteLine(obj.GetType());

        ConstructorInfo ctor2 = type.GetConstructor(new Type[] { typeof(string), typeof(int) });
        // ConstructorInfo ctor2 = type.GetConstructor(new Type[] { System.String, System.Int32 });   // it will give error why? because it except "Type" Class Object but we are passing "System" class Object. typeof(string) and typeof(int) here it belongs to Type Class
        object obj2 = ctor2.Invoke(new object[]{"Aryan", 22});
        // var [name, age] = obj2;
        Console.WriteLine(obj2);
        Console.WriteLine(obj2.GetType());
        Console.WriteLine(typeof(string));  // output: System.String
        Console.WriteLine(typeof(int));    // output: System.Int32





    }

}
class Employee
{
    public int Id {get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
    private double _salary;

    public Employee(string name, int id)
    {
        Id = id;
        Name = name;
    }
    public Employee(){}

    // public void Work(int n)
    // {
    //     Console.WriteLine("Employee - Work: " + n);
    // }
    public void Work(int n, int m)
    {
        Console.WriteLine("Employee - Work: " + n+m);
    }
    public void SetSalary(double salary)
    {
        _salary = salary;
    }
}