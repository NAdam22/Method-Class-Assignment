using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass_Assignment
{
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Instantiate the class
            MathClass myClass = new MathClass();

            // Call method with normal parameters
            myClass.DoMath(5, 10);
            // Call method with named parameters
            myClass.DoMath(firstNumber: 7, secondNumber: 20);
            // Pause console
            Console.WriteLine("Press any key to exit..."); 
            Console.ReadKey();
        }
    }
}
