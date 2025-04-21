using System;

class InputOutput
{
    public static void Main(string[] args)
    {
        try
        {
            //--------------Numeric Input Output-----------------//
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Basic concatenation output
            Console.WriteLine($"{a} and {b} addition is: {a + b}");

            // Using variable
            int c = a + b;
            Console.WriteLine($"Result: {c}");

            // Different output methods
            Console.Write("Normal output using concatenation: " + c + "\n");

            // String interpolation
            var resultMessage = $"Addition of {a} and {b} is: {c}";
            Console.WriteLine("String interpolation output: " + resultMessage);

            //--------------Float Input Output-----------------//
            Console.WriteLine("Enter Float Value:");
            string value = Console.ReadLine();

            double percentage = Convert.ToDouble(value);
            Console.WriteLine("Percentage Input Output: {0}", percentage);

            Console.WriteLine("Enter another float value directly:");
            double percentage2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second Float: {0}", percentage2);


            //--------------String Input Output-----------------//
            Console.WriteLine("Enter first Name:");
            string x = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            string y = Console.ReadLine();

            Console.WriteLine("Your Full Name is {0}  {1}",x,y);

         
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format Exception: " + ex.Message);
            Console.WriteLine("Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
