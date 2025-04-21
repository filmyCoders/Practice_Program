

using Microsoft.VisualBasic;
using System.Text;

public class IntrerviewProgram
{

    public static void Main(string[] args)
    {

        StringProgram stringProgram = new StringProgram();
        stringProgram.ReverseString("Nikhil");
        stringProgram.CheckStringPalindrome("MADAM");
      var aa=   stringProgram.CountVowelsAndConsonants("uoiuio");
        Console.WriteLine("Consnatnts:"+aa.consonats+"   Vowels:"+aa.vowels);

        //Object aa = stringProgram.CountVowelsAndConsonants("uoiuio");
        //Console.WriteLine("Consnatnts:" + aa + "   Vowels:" + aa);

        var ssd=stringProgram.CountVowelsAndConsonantsChar("Nikhil Chavan");
        ssd.vowels.Replace(" ", "");

        ssd.vowels=string.Join(",",ssd.vowels.ToCharArray());
        ssd.consonats = string.Join(",", ssd.consonats.ToCharArray());

        Console.WriteLine("Cons:"+ssd);

        stringProgram.SwapStringWithoutThirrdVariable("Nikhil", "Chavan");

        stringProgram.FirstNonRepatingChar("abbccddcde");

        stringProgram.RemoveDuplicateElemnet("VVVBEUCeeeeucccj  &&&cdjcde");
    }
}


//1 Reverse a string without using built-in methods.


class  StringProgram
{

    public void ReverseString(string s)
    {

        char[] chars = s.ToCharArray();
        string rev="";
        for(int i = chars.Length-1; i >= 0; i--)
        {

            rev = rev + chars[i];
        }
        Console.WriteLine(rev);


        if (string.IsNullOrEmpty(s))
        {

        };

        var sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]); // More efficient than string concatenation
        }
        Console.WriteLine(sb);


    }

    public void CheckStringPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Empty string is considered a palindrome");
            return;
        }

        StringBuilder sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        string message = sb.ToString() == s
            ? "This String is Palindrome"
            : "This String is Not Palindrome";
        Console.WriteLine(message);

    }

    public (int consonats, int vowels) CountVowelsAndConsonants(string s) {

        char[] chars = s.ToCharArray();
        char[] vowels= { 'a', 'e', 'i', 'o', 'u' };
        int consonatsCount=0,vowelsConut=0;

        if (string.IsNullOrEmpty(s)) { }

            for (int i = 0; i <= s.Length-1; i++)
            {
                
                    if (vowels.Contains(chars[i]))
                    {
                        consonatsCount++;

                    }
                    else
                    {
                        vowelsConut++;

                    }
                
            }

        return (consonatsCount, vowelsConut);
    }

    public (string consonats, string vowels) CountVowelsAndConsonantsChar(string s)
    {

        char[] chars = s.ToCharArray();

        List<char> vowels=new List<char>();
        List<char> consonats =new List<char>();

        var vowelsCheck =new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

foreach(char i in chars)        {
            if (vowelsCheck.Contains(i))
            {
                vowels.Add( i);
            }
            else
            {
                consonats.Add(i);
            }
        }

        Console.WriteLine(consonats);

        return (
               new string(consonats.ToArray()),
               new string(vowels.ToArray())
           );
    }

    public void SwapStringWithoutThirrdVariable(string s,string s1)
    {
        Console.WriteLine("Without Swap");

        Console.WriteLine("Variable1 "+ s);
        Console.WriteLine("Variable2 "+ s1);

        s = s + s1;
        s1 = s.Substring(0, 6);
        s= s.Substring(6);
        Console.WriteLine("With Swap");

        Console.WriteLine("Variable1 "+s);
        Console.WriteLine("Variable2 "+s1);

    }


    //First Non-Repeating Character

   public void FirstNonRepatingChar(string s)
    {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic[c]=1;
                // dic[c]=1;
            }

        }
        

          foreach(char c in s)
        {
            if (dic[c] == 1)
            {
                Console.WriteLine(c);
                break;
            }
        }
    }


    //Remove Duplicates


    public void RemoveDuplicateElemnet(string s)
    {
        HashSet<char> hash=new HashSet<char>();
        StringBuilder sb=new StringBuilder();

        Console.WriteLine("Orignale String is:" + s);

        foreach(char c in s)
        {
            if (hash.Add(c))
            {
                sb.Append(c);
            }
        }

        Console.WriteLine("Removed Repeated Characters in a string" );

        Console.WriteLine(sb.ToString());
    }
}



/*
 
 
 🔹 Basic Programs
Reverse a string without using built-in methods.

Check if a number is prime.

Print Fibonacci series up to n terms.

Check if a string is a palindrome.

Swap two numbers without using a third variable.

Calculate factorial of a number using recursion.

Count vowels and consonants in a string.

Find the largest and smallest number in an array.

Print multiplication table of a number.

Find sum of digits of a number.

🔹 Array and List Programs
Find duplicate elements in an array.

Remove duplicates from a list using LINQ.

Sort an array without using built-in sort.

Merge two arrays into one.

Find common elements in two arrays.

🔹 OOPs-Based Programs
Create a class Employee with properties and display employee info.

Implement inheritance using Vehicle → Car, Bike.

Create an interface IShape and implement Rectangle, Circle.

Demonstrate method overloading and overriding.

Create a static class and call its method.

🔹 LINQ & Collections
Get all even numbers from a list using LINQ.

Group employees by department using LINQ.

Find the second highest number in a list using LINQ.

Sort a list of strings in descending order.

Convert a list to a dictionary using LINQ.

🔹 Delegates, Events & Lambda
Create a delegate and call a method using it.

Use anonymous method with a delegate.

Create an event and trigger it.

Use a lambda expression to filter values in a list.

🔹 Exception Handling & File I/O
Read and write to a text file using StreamReader and StreamWriter.

Handle divide by zero exception.

Create a custom exception and use it.

🔹 String Manipulation
Count frequency of characters in a string.

Remove all white spaces from a string.

Find first non-repeating character in a string.

Check if two strings are anagrams.

🔹 Date & Time
Get current date and time in specific format.

Calculate difference between two dates.

Add 10 days to current date.

🔹 Advanced Logic
Create a program to validate an email address.

Print pyramid/star patterns.

Program to check Armstrong number.

Convert a number to words (e.g., 123 → "One Two Three").

Implement CRUD operations on a list of objects.


  
 
 */

