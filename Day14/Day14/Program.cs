// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {

        /*
        string path1 = "data.txt";

        string path2 = @"C:\Users\hp\Desktop\day2\data2.txt.txt";

        string content = "File I/O Example in C#";

        File.WriteAllText(path1, content);
        Console.WriteLine("Data written to data.txt");

        string readData = File.ReadAllText(path1);

        string directoryPath = Path.GetDirectoryName(path2);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
            
        }



/*
---------------------------------------------------------------------------------
        string file1 = "data.txt";

        string file2 = @"C:\Users\hp\Desktop\day2\data2.txt.txt";

        File.WriteAllText(file1, "File I/O Example in C#");

//Readalltext.
        string content = File.ReadAllText(file1);

        Console.WriteLine("File Content:");
        Console.WriteLine(content);

        string dir = Path.GetDirectoryName(file2);
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        // Share data to data2.txt (outside)
        File.WriteAllText(file2, content);

        Console.WriteLine("\nData successfully shared to data2.txt");


        --------------------------------------------------------------------------
   */

/*
        File.WriteAllText(path2, readData);
        Console.WriteLine("Data shared and written to data2.txt (outside folder)");
    }
}
----------------------------------------------------------------------
*/

//--using StreamWriter-- using used so that dipose is automatically called.--
/*

using (StreamWriter writer = new StreamWriter("log.txt"))
        {
            writer.WriteLine("Application Started");
            writer.WriteLine("Processing Data");
            writer.WriteLine("Application Ended");
        }

        using (StreamReader reader = new StreamReader("log.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

*/
//-----------------------------------------------------------------------------------

//persisting object---
/*

------------------------------------------------------------------------------

Users user = new Users { Id = 1, Name = "Alice" };

        using (StreamWriter writer = new StreamWriter("user.txt"))
        {
            writer.WriteLine(user.Id);
            writer.WriteLine(user.Name);
        
         user.Id = 2;
            user.Name = "Bob";

            writer.WriteLine(user.Id);
            writer.WriteLine(user.Name);
        }
        Console.WriteLine("User data saved.");
----------------------------------------------------------------------*/
/*
 Users user = new Users();

        using (StreamReader reader = new StreamReader("user.txt"))
        {
            user.Id = int.Parse(reader.ReadLine());
            user.Name = reader.ReadLine();
        }
        Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");
---------------------------------------------------------------------
*/

/*
        User user = new User { Id = 2, Name = "Bob" };

        using (BinaryWriter writer =
               new BinaryWriter(File.Open("user.bin", FileMode.Create)))
        {
            writer.Write(user.Id);
            writer.Write(user.Name);
        }

        Console.WriteLine("Binary user data saved.");
---------------------------------------------------------------------------
*/
/*


       using (BinaryWriter writer =
               new BinaryWriter(File.Open("data.bin", FileMode.Create)))
        {
            writer.Write(101);
            writer.Write("Hello Binary File");
        }

        // Read binary data
        using (BinaryReader reader =
               new BinaryReader(File.Open("data.bin", FileMode.Open)))
        {
            int number = reader.ReadInt32();
            string text = reader.ReadString();

            Console.WriteLine(number);
            Console.WriteLine(text);
        }

*/

                                   //-------------------Day 15------------------

        //     FileInfo file=new FileInfo("sample.txt");
        //     if(!file.Exists)
        // {
        //     using(StreamWriter writer = file.CreateText())
        //     {
        //         writer.WriteLine(" --Hello FileInfo Class--");
        //     }
        // }
        // Console.WriteLine("File Name: "+file.Name);
        // Console.WriteLine("File Size: "+ file.Length + " bytes");
        // Console.WriteLine("Created On: "+file.CreationTime);


//-------------------------------------------------------------------------------------------
        //directory
        /*Directory.CreateDirectory("Logs");
        if(Directory.Exists("Logs"))
        {
            Console.WriteLine(" logs Directory created");
        }
        */
        //-----------------------------------------------------
       
       /* DirectoryInfo dir = new DirectoryInfo("Logs");
        if(!dir.Exists)
        {
            dir.Create();
        }
        Console.WriteLine("Directory Name: "+ dir.Name);
        Console.WriteLine("Created On: "+ dir.CreationTime);
        Console.WriteLine("Full Path: "+ dir.FullName);
        */
        //--------------------------------------------------
        //serialization

        // Userr user = new Userr {Id = 1, Name = "Alice"};
        // string json=JsonSerializer.Serialize(user);
        // File.WriteAllText("user.json",json);
        // Console.WriteLine("User serialized successfully..");

        //deserialization--
        // string json = File.ReadAllText("user.json");
        // Userr user = JsonSerializer.Deserialize<Userr>(json);
        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

        Userr user = new Userr {Id = 1, Name = "Alice"};
        XmlSerializer serializer = new XmlSerializer(typeof(User));
        using(FileStream fs = new FileStream("user.xml",FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }
        Console.WriteLine("XML Serialized");
    }
}






