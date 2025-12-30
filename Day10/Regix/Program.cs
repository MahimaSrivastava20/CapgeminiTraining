using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
class program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Day 10!");

        // string sentence = "abc123";        // testcase 1
        // string sentence = "123123abc";        // testcase 2
        // string pattern = @"\d";

        // Regex.IsMatch() Method
        // bool res = Regex.IsMatch(sentence, pattern);
        // Console.WriteLine(res);

        // string sentence = "Amount: 500";        // testcase 3

        // string pattern = @"\d+";    // Digit (At least 1 Digit)
        // string pattern = @"\d*";          // Digit (0 or more Digit)

        // Regex.Match() Method

        // string sentence = "10A20B30C";
        // string sentence = "10A20B30C!@_ abc \t";
        // string pattern = @"\D";     // Non-Digit
        // string pattern = @"\w";     // Word Character (Small w)
        // string pattern = @"\W";       // Non-word Character (Capital W)
        // Match m = Regex.Match(sentence, pattern);
        // Console.WriteLine(m.Value);

        // string sentence = "Date: 2025-12-29";
        // string pattern = @"(\d{4})-(\d{2})-(\d{2})";       // Non-word Character (Capital W)
        // Match m = Regex.Match(sentence, pattern);
        // Console.WriteLine(m.Value);

        // string sentence = "Date: 2025-12-29";
        // string pattern = @"(\d{4})-(\d{2})-(\d{2})";       // Non-word Character (Capital W)
        
        
        // string sentence = "Amount=500";
        // string pattern = @"Amount=(?<value>\d\d+)";
        // Match m = Regex.Match(sentence, pattern);
        // Console.WriteLine(m.Value);

//Email Pattern Matching...



        List<string> Emails = new List<string>
        {
            "john.doe@gmail.com",
            "alice_123@yahoo.in",
            "mark.smith@company.com",
            "support-abc@banking.co.in",
            "user.nametag@domain.org",
            "john.doe@gmail",          // Missing domain extension
            "alice@@yahoo.com",        // Double @
            "mark.smith@.com",         // Domain missing name
            "support@banking..com",    // Double dot in domain
            "user name@gmail.com",     // Space not allowed
            "abc@gamil.com.def@yahoo.com", 
            "@domain.com",             // Missing username
            "admin@domain",            // No top-level domain
            "info@domain,com",         // Comma instead of dot
            "finance#dept@corp.com",   // Invalid character #
            "plainaddress"             // Missing @ and domain
            
};

        string pattern=@"\b[\w.-]+@[\w.-]+\.\w{2,}$\b";
        foreach(string input in Emails)
        {
        if(Regex.IsMatch(input,pattern))
        {
            Console.WriteLine("Valid email found"+input);
        }
            else
            {
                Console.WriteLine("Invalid Email"+input);
            }
        }








// DATE  AND  TIME ---code---
        // string Pattern= @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // //string Input="23-02-1992";
        // string Input="1992-02-23";

        // Match m=Regex.Match(Input,Pattern);
        // Console.WriteLine(m.Groups["year"].Value);
        // Console.WriteLine(m.Groups["month"].Value);
        // Console.WriteLine(m.Groups[0].Value);
        // Console.WriteLine(m.Groups[1].Value);
        // Console.WriteLine(m.Groups[2].Value);

//code-----------------APPLE------------

        // string Input="grapple apples a!-@3 apple";
        // //string pattern=@"a..";
        // string pattern=@"a...e";  

        // Match m=Regex.Match(Input,pattern);
        // MatchCollection matches = Regex.Matches(Input, pattern);
        // Console.WriteLine(m.Value);
        // foreach(var mat in matches)
        // {
        //     Console.Write(mat+" ");
        // }

        // string sentence = "10 20 30";
        // string pattern = @"\d+";

        // string sentence = "10A20B30C";
        // string pattern = @"\D";

        //Matches() method
        // MatchCollection matches = Regex.Matches(sentence, pattern);
        // Console.WriteLine(matches);
        // foreach(var m in matches)
        // {
        //     Console.WriteLine(m);
        // }

        // string sentence2 = "10A20B30C !@_\tabc";
        // string pattern2 = @"\w";
        // string pattern2 = @"\W";

        // string sentence2 = "10A20B30C !@_\tabc";
        // string pattern2 = @"\s";       // Whitespace, space
        // string pattern2 = @"\S";       // except (Whitespace, space)

        // string sentence2 = "10A20B30C !@_\tabc file.txt";
        // string pattern2 = @"\.txt";      

        // string sentence2 = "C:\\abc\file.txt";
        // string pattern2 = @"\\"; 

        // string sentence2 = "C:?\abc\file.txt?";
        // string pattern2 = @"\?";   

        // string sentence2 = "Hello?C:?\abc\file.txt?Hello";
        // string sentence2 = "Hello?C:?\abc\file.txt?Hello";
        // string pattern2 = @"^Hello";      
        // string pattern2 = @"^Hello$";      
        // string pattern2 = @"Hello$";      
        // string pattern2 = @"lo$";      
        // MatchCollection matches = Regex.Matches(sentence2, pattern2);
        // Console.WriteLine(matches);
        // foreach(var mat in matches)
        // {
        //     Console.Write(mat);
        // }


    }
}