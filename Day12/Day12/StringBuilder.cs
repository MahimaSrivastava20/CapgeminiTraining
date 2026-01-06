using System.Text;
class StringBuilderExample
{
    public static void stringbuilder()
    {
        StringBuilder sb1 = new StringBuilder("Hello");
        StringBuilder sb2 = new StringBuilder("Hello");


        Console.WriteLine("Equals() Method: " + sb1.Equals(sb2));
        Console.WriteLine(sb1==sb2);
        StringBuilder sb3 = sb2;
        Console.WriteLine("Equals() Method: " + sb3.Equals(sb2));

        Console.WriteLine("Is Object Reference Equals: " + object.ReferenceEquals(sb1, sb2));
        Console.WriteLine("Is Object Reference Equals: " + object.ReferenceEquals(sb3, sb2));

        string s1 = new string("abc");
        string s2 = new string("abc");
        Console.WriteLine("Equals() Method: " + s1.Equals(s2));
        Console.WriteLine(s1 == s2);
        Console.WriteLine("Is Object Reference Equals: " + object.ReferenceEquals(s1, s2));

        string str1 = "hello";
        string str2 = "hello";
        Console.WriteLine("Equals() Method: " + str1.Equals(str2));
        Console.WriteLine(str1 == str2);
        Console.WriteLine("Is Object Reference Equals: " + object.ReferenceEquals(str1, str2));

        string num1 = "12";
        int num2 = 12;
        Console.WriteLine("Equals() Method: " + num1.Equals(num2.ToString()));
        Console.WriteLine(num1 == num2.ToString());
        Console.WriteLine("Is Object Reference Equals: " + object.ReferenceEquals(num1, num2));


    }
}