
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTraining
{
    internal class FindGreatest
    {
        private int num1, num2, num3;

        public FindGreatest(int a, int b, int c)
        {
            num1 = a;
            num2 = b;
            num3 = c;
        }

        public int Grater()
        {
            if (num1 >= num2 && num1 >= num3)
                return num1;
            else if (num2 >= num1 && num2 >= num3)
                return num2;
            else
                return num3;
        }

        // Main method to test the class
        static void Main(string[] args)
        {
            // Example usage
            FindGreatest finder = new FindGreatest(10, 25, 15);
            int greatest = finder.Grater();
            Console.WriteLine("The greatest number is: " + greatest);
        }
    }
}
