using System;
using System.Linq;


namespace Arrays_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] userName = new string[5];

                for (int i = 0; i < userName.Length; i++){

                    userName[i] = Console.In.ReadLine();
                }
            
                for (int i = 0; i < userName.Length; i++)
                {
                    Console.WriteLine("hello " + userName[i]);
                }
                
        Console.WriteLine("========================"); 
                
        ///task 2 

        int[] userValue = new int [10] {34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
        
        int sum = userValue.Sum();
        Console.WriteLine(sum);


        }
    }
}


/* Create a program that reads in 5 names from the console.  It then prints out "Hello <name>" for all the names entered
A program starts with the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0. Write a program that adds all numbers together and outputs the total. */