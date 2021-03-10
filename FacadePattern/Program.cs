// Ali Abu-Alizz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    // This program demonstrates the facade design pattern
    // by printing a string from the methods of 7 different classes
    // in a specific order
    public class Program
    {
        public static void Main(string[] args)
        {
            FacadeUser user = new FacadeUser(); // This object implements the facade pattern 
                                                // and already has a specific string made up of
                                                // the classes' methods ready to be printed


            string message = user.Order();  // The string ready to be printed

            Console.WriteLine(message); // Printing the string
            Console.ReadLine();
        }
    }
}
