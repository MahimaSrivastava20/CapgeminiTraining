//Arrays
//int[] numbers;
//int[] numbers=new int[5];
//int[] numbers={10, 20, 30, 40, 50};

using System.Collections;
using System.Data;
using System.Diagnostics.CodeAnalysis;

class Arrayss
{
    public static void Arrays()
    {
        //   int[] numbers;
        //   int[] numbers=new int[5];
           int[] numbers={10, 20, 30, 40, 50};
        //   bool found=Array.Exists(numbers,x=>x>25);
        //Console.Write(found);
          //bool found=Array.Exists(numbers,x=>x>25);

          //Array.Clear(numbers,0,numbers.Length);
          //Array.Clear(numbers,0,numbers.Length-1);
            foreach(int x in numbers)
        {
            Console.WriteLine(x);
        }
        bool found=Array.Exists(numbers,x=>x>25);
        Console.Write(found);

//----------------------------------------------------------------

          int[] src= {1, 2, 3};
          int[] dest= new int[3];
          //Array.Copy(src, dest, 1);
          //Array.Copy(src, dest, 2);
          //Array.Copy(src, dest, 3);
          
        //   foreach(int x in dest)
        // {
        //     Console.WriteLine(x);
        // }
//------------------------------------------------------------------


        //Resize
        int[] nums={33,22};
        Array.Resize(ref nums, 4);
        //Array.Resize(nums,4);(cannot be used without ref...)
        //Array.Resize(nums,1);
        //  foreach(int x in nums)
        //{
        //    Console.Write(x+ " ");
        //}

//-------------------------------------------------------------------
//seperate varaible and apply on 1.

//  int[] exe={33,22};
//         Array.Resize(ref exe, 1);
//         //Array.Resize(nums,4);(cannot be used without ref...)
//         //Array.Resize(nums,1);
//           foreach(int x in exe)
//         {
//             Console.Write(x+ " ");
//         }

//         //int[,] matrix=new int[2,2];
//         int[,] matrix={{12,24,30},{4,5,6}};
        
//             for(int i=0;i<matrix.GetLength(0);i++)
//             {
//                 for(int j=0;j<matrix.GetLength(1);j++)
//                 {
//                     Console.Write(matrix[i, j]+"  ");
//                 }
//                 Console.WriteLine();
//             }

//         int[][] jagged = new int[2][];
//         jagged[0]=new int[] {1,2};
//         jagged[1]=new int[] {3,4,5};
//         for(int i=0;i<jagged.Length;i++)
//         {
//             for(int j=0;j<jagged[i].Length;j++)
//             {
//                 Console.Write(jagged[i][j]+"  ");
//             }
//             Console.WriteLine();
//         }
//         List<int> list1=new List<int>();
//         list1.Add(32);
//         list1.Add(34);
//         list1.Add(35);
//         list1.Add(36);
//         list1.Add(37);


//         ArrayList arraylist1=new ArrayList();
//         arraylist1.Add(51);
//         arraylist1.Add(52);
//         arraylist1.Add(53);
//         arraylist1.Add(54);

//         foreach(int n in list1)
//         {
//             Console.Write(n+ " ");

//         }
//         foreach(int d in arraylist1)
//         {
//             Console.Write(d+" ");
//         }

//--no type safety, non-generic--
        // Hashtable ht=new Hashtable();
        // ht.Add(1,"Aman");
        // ht.Add(2,"Sana");
        // Console.WriteLine(ht[1]);


//stack
        // Stack stack=new Stack();
        // stack.Push(10);
        // stack.Push(20);
        // Console.WriteLine(stack.Pop());
        // Console.WriteLine(stack.Pop());


//queue
        // Queue queue=new Queue();
        // queue.Enqueue(10);
        // queue.Enqueue(20);
        // Console.WriteLine(queue.Dequeue());       

//Dictionary
        // Dictionary<int,string> dict= new Dictionary<int, string>();
        // dict.Add(1,"Mahima Srivastava");    
        // dict.Add(2,"Shanaya");  
        // Console.WriteLine(dict[1]); 


//HashSet- only unique values allowed.
        // HashSet<int> hset=new HashSet<int>();
        // hset.Add(1);
        // hset.Add(2);
        // hset.Add(3);
        // hset.Add(3);//there is no error if we add duplicate values in hashset it ignores them.
        // foreach(int n in hset)
        // {
        //     Console.Write(n+ " ");

        // }
        
//sortedlist
//         SortedList<string,string> slist=new SortedList<string,string>();
//         slist.Add("a","A");
//         slist.Add("b","B");
//         Console.WriteLine("Sorted List");
//         foreach(var ch in slist)
//         {
//             Console.WriteLine(ch+" ");
//             Console.WriteLine(ch.Value+" ");
//             Console.WriteLine(ch.Key+" "+ch.Value);

//         }
// //unordered- Dictionary,HashSet-[foreach is recommended]
// //
//Dictionary using foreach
        Dictionary<int, string> employees = new Dictionary<int, string>();
        employees.Add(101, "Ravi");
        employees.Add(102, "Amit");
        employees.Add(103, "Neha");

        foreach (KeyValuePair<int, string> emp in employees)
        {
            Console.WriteLine(emp.Key + " - " + emp.Value);
        }
        //using var....
        foreach (var emp in employees)
        {
            Console.WriteLine(emp.Key + " - " + emp.Value);
        }











    }
}
//Arrays are faster than list.
//Jagged Array





















