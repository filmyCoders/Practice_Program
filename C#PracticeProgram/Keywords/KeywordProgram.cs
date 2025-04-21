using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Reflection;
using System.Threading;
using System;

public class KeywordProgram
{
    public static void Main(string[] args)
    {

        int x ,y;

        Console.WriteLine("Enter Number Addtion");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        Student student = new Student();
        student.Additon(ref x, y);
        Console.WriteLine("Addition is: " + x);

        int redius;


        
        student.CicleRedius(out redius);
        Console.WriteLine("Cicle Redius Is By Using Out KeyWord" + redius);

        //****************Is Keyword**************************

        int isKeyword = 30;

        if(isKeyword is int)
        {
            Console.WriteLine($"{isKeyword} is Integer");
            //This Block Excecute

        }
        else
        {
            Console.WriteLine($"{isKeyword} is Not Integer");
        }

        if (isKeyword is string)
        {
            Console.WriteLine($"{isKeyword} is String");
        }
        else
        {
            //This Block Excecute
            Console.WriteLine($"{isKeyword} is Not String");
        }




        //**************** as Keyword**************************

        object name = "Nikhil";
        string a = name as string;
        Console.WriteLine(nameof(name));

        if (a!=null)
        {
            Console.WriteLine($"Value is {a}");
            Console.WriteLine($"Conversion Successfully");



            //This Block Excecute


        }
        else
        {
            Console.WriteLine($" Conversion Fails");
        }

        





        #region Notes Check



        // Common C# Keywords in Interviews & Projects:

        // 1. ref       // Pass by reference
        // 2. out       // Pass without initialization, must assign inside method
        // 3. in        // Pass by reference but as read-only
        // 4. as        // Safe casting
        // 5. is        // Type checking
        // 6. using     // For resource disposal or namespaces
        // 7. var       // Implicit type
        // 8. dynamic   // Runtime type resolution
        // 9. async     // Asynchronous method
        // 10. await    // Await asynchronous operation
        // 11. yield    // Return sequence in iterator
        // 12. lock     // Thread synchronization
        // 13. try      // Exception handling
        // 14. catch    // Exception catch block
        // 15. finally  // Cleanup block after try-catch
        // 16. throw    // Throwing exceptions
        // 17. params   // Variable number of parameters
        // 18. sealed   // Prevent class inheritance
        // 19. abstract // Abstract class/method
        // 20. override // Override base class method
        // 21. virtual  // Allow method overriding
        // 22. static   // Belongs to class, not instance
        // 23. const    // Compile-time constant
        // 24. readonly // Runtime constant (can be set in constructor)
        // 25. this     // Current instance reference
        // 26. base     // Access base class members
        // 27. new      // Hides base class member
        // 28. get/set  // Property accessors
        // 29. interface// Defines a contract
        // 30. namespace// Organize classes
        // 31. class    // Blueprint of object
        // 32. struct   // Value type
        // 33. enum     // Enumeration type
        // 34. typeof   // Get type info at runtime
        // 35. nameof   // Get string name of a variable/method/property
        // 36. switch   // Selection statement
        // 37. break    // Exit loop/switch
        // 38. continue // Skip to next loop iteration
        // 39. foreach  // Loop over a collection
        // 40. if/else  // Conditional branching

        // Tip: You don’t need to memorize all, but knowing when and where to use them is key for interviews and real projects.

        /*  Keyword Why It’s Important(Interview +Real Project Use)
  ref / out / in	Deep understanding of parameter passing is often tested. Especially ref vs out.

  async / await Crucial for modern apps (especially Web APIs, UI apps). Async programming is a hot topic.

  using Used for memory / resource management(IDisposable) and namespace.Used in DbContext, file handling, etc.

  var / dynamic Interviewers test your understanding of type safety.Also used in LINQ.

  interface Deep dive on abstraction and dependency injection.Real-world architecture uses interfaces a lot.
  abstract / virtual / override / sealed Polymorphism control – interviewers test these for OOP clarity.
  try / catch / finally / throw	Exception handling – you're expected to handle errors properly in production code.
  lock	Multithreading and thread-safety – often asked if you've worked with shared data.
  yield Advanced topic – useful for lazy iteration. Asked in LINQ or performance-focused roles.
  params Handy when designing flexible APIs.Not asked often but nice to know.
  readonly / const	Constant management – a common practical question. Often misunderstood.
  nameof / typeof	nameof is best practice in error messages/logging; typeof used in reflection.Often seen in real code.


  */
        #endregion





    }

    class Student
    {
        public void Additon(ref int a,int b )
        {
            a = a + b;

        }


        public void CicleRedius(out int c) 
            {


            c = 360;

        }
    }
}
