using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("For loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n while looop");
        int j = 0;

        while (j < 5)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine("\n do while loop");
        int k = 0;
        do
        {
            Console.WriteLine(k);
            k++;

        }
        while (k < 5);

        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("\n foreach loop");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}