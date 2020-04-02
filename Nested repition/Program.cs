using System;

namespace selectiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
    
       //Exercise 2
        //Task 1
         /* 
                 
                    string name = "x";
                    
                     for (int counter = 0; counter <10; counter++) 
                    {

                        for (int counter2 = counter; counter2 < 5; counter2++)
                        {
                            System.Console.Write(name);
                        }
                    
                        System.Console.WriteLine();
                    }
            */
             
        //task2
        
         /*    
                    string name = "x";
             
                    
                    Console.Write("please enter a number between 1 and 5\n");

                    int userCounter = Int32.Parse(Console.ReadLine());
                   
                    for (int counter = userCounter; counter > 0; counter--){

                        for (int counter2 = counter; counter2 > 0; counter2--)
                        {
                            System.Console.Write(name);
                        }
                    
                        System.Console.WriteLine();
                    }
            
         */
        /*    // Task 3
                        
            int counter = 1;
                   
                

            while (counter <=5)
            {
                for (int i = 1; i <=counter; i++){
                    Console.Write("X");
                }
                
                Console.WriteLine();

                counter ++;

            }
                    
                
          */              

            //task 4 
            Console.WriteLine("please enter a number b/w 1 and 5");
            int userCounter = Int32.Parse(Console.ReadLine());
                            

            while (userCounter <=5){

                for (int i = 1; i <=userCounter; i++){
                    Console.Write("X");
                }
                
                Console.WriteLine();

                userCounter ++;

            }
                    
              
            
        }
    }
}
