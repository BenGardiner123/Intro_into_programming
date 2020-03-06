using System;

namespace selectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
                string username = "bennygards";
                string password = "1234";

                string userinput;
                string passinput;

        Console.WriteLine("Please enter username");

        userinput = Console.ReadLine();

        Console.WriteLine("Please enter password");

        passinput = Console.ReadLine();

        
        
        if (username == userinput)
        
            {
             if ((username == userinput) && (password == passinput))
    
            {
                Console.WriteLine("Login successful");
            }
            else 
                {
                Console.WriteLine("Login unsuccessful");
                }
            }
        else
        {
         Console.WriteLine("Login unsuccessful");   
        }
        Console.ReadLine();
        
        }
    }
}
