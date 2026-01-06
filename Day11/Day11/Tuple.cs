class TupleExample
{
    public static void Tuples()
    {
        var student = (Id: 101, Name: "Aryan");        // Tuple
        Console.WriteLine(student.GetType());

        var anno = new        // AnonymousType
        {
            Id = 101, 
            Name = "Aryan"
        };
        Console.WriteLine(anno.GetType());



        
    }
    public static (int sum, int avg, int diff) Calculate(int a, int b)
    {
        return (a+b, (a+b)/2, a-b);
    }

    public static (bool isValid, string message) ValidateUser(string username)
    {
        if (string.IsNullOrEmpty(username))
        {
            return (false, "Username is required!");
        }

        return (true, "Valid User");
    }
}