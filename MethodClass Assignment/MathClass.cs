using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass_Assignment
{
    // Define a class named MathClass
    class MathClass
    {
        // Method that takes two integers, performs math on the first, and displays the second
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2
            int result = firstNumber * 2;
            // Display result
            Console.WriteLine("Result of math operation on first number: " + result);
            // Display second number
            Console.WriteLine("Second number is: " + secondNumber); 
        }
    }
}
