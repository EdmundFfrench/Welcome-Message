// Author: Ed French
// SID: EJF143
// Edited: 23/09/2019
using System;

namespace Welcome_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string message;
            string courseName;
            const string UNIVERSITYNAME = "Anglia Ruskin";

            Console.WriteLine("Please Enter Your Name");

            //  Here we use readline to put string data into a variable
            name = Console.ReadLine();

            // Construct a welcome message
            message = "Welcome.." + name + " to " + UNIVERSITYNAME;

            // Write the message to the console
            Console.WriteLine(message);

            // QUESTION 1
            Console.WriteLine("Which course are on?");

            //  Here we use readline to put string data into a variable
            courseName = Console.ReadLine();

            // Construct a welcome message for course
            message = "Welcome to the " + courseName + " course at " + UNIVERSITYNAME;
            Console.WriteLine(message);

            // Here we use readline to just to 'pause' the program
            Console.ReadLine();
        }
    }
}
