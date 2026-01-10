using System;

class AreaOfCircle
{
    public static void area_of_circle()
    {
        Console.WriteLine("Enter the radius of the circle:");

        double r = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * r * r;


        Console.WriteLine("The area of the circle is: " + area);
        
    }
}