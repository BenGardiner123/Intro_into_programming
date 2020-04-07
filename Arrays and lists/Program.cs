using System;
using System.Linq;
using System.Collections.Generic;  


namespace Arrays_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
/*                 string[] userName = new string[5];

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
 */
         List<int> myNum = new List<int>();

        Console.WriteLine("Please enter 5 numbers...");

        for (int i = 0; i < 5; i++)
        {
            myNum.Add(int.Parse(Console.ReadLine()));
        }
        
        Console.WriteLine("Please enter another number...");
        int usernum = Int32.Parse(Console.ReadLine());

        if (myNum.Contains(usernum)){
            Console.WriteLine("your number aleady exits...");
        }

        else {
        Console.WriteLine("good work......");
        }
         

/* rite a program that reads in 5 numbers. It then asks the user for another number and outputs whether the number has already been entered.
As above except the program will tell the user how many times a repeated number has been entered
A program stores words read from console, until the word "stop" is entered.  It then outputs the words entered in reverse order. */
        }
    }
}


