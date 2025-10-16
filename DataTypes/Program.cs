using System;

namespace BridgeLabsTraining
{
    internal class DataTypesDemo
    {
        static void Main(string[] args)
        {
            // Integer types
            int intNum = 100;
            long longNum = 10000000000L;
            short shortNum = 32000;
            byte byteNum = 255;


            float floatNum = 12.34F;
            double doubleNum = 123.456;
            decimal decimalNum = 12345.6789M;


            char letter = 'A';
            string name = "BridgeLabz";


            bool isActive = true;


            Console.WriteLine("int: " + intNum);
            Console.WriteLine("long: " + longNum);
            Console.WriteLine("short: " + shortNum);
            Console.WriteLine("byte: " + byteNum);
            Console.WriteLine("float: " + floatNum);
            Console.WriteLine("double: " + doubleNum);
            Console.WriteLine("decimal: " + decimalNum);
            Console.WriteLine("char: " + letter);
            Console.WriteLine("string: " + name);
            Console.WriteLine("bool: " + isActive);

            // Getting user input and converting
            Console.Write("Enter an integer: ");
            int userInt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a double: ");
            double userDouble = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a character: ");
            char userChar = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter true or false: ");
            bool userBool = Convert.ToBoolean(Console.ReadLine());

            double castDouble = userInt; // Implicit cast (int to double)
            int castInt = (int)userDouble; // Explicit cast (double to int)

            Console.WriteLine("You entered int: " + userInt);
            Console.WriteLine("You entered double: " + userDouble);
            Console.WriteLine("You entered char: " + userChar);
            Console.WriteLine("You entered bool: " + userBool);

            Console.WriteLine("Implicit cast int to double: " + castDouble);
            Console.WriteLine("Explicit cast double to int: " + castInt);
        }
    }
}

