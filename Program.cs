// Author: Xiao Lin
// Date: 09/26/2020
// Description: This c# allication code demonstrates the use of arrays after geting input from users.e

using System;

namespace Tech_Proj_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use try and catch block to automatically populate th arrays
            // No user input require in this situation
            try
            {
                int[] n = new int[25]; // 25 elements will be display on the program

                Console.WriteLine("There are 25b elements should be populated in the array."); 
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("");

                
                for (int i=0; i<25; i++) 
                {
                    n[i] = i + 1;
                }

                foreach (int j in n)
                {
                    int i = j;
                    Console.WriteLine("Element value = {0}", i, j);
                }

                Console.WriteLine("");
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Press any key to exit the program..."); // Ask the user to close the program
                Console.ReadKey(true);
            } // End of catch
        } //End of main
    } //End of program
} //End of namespace
